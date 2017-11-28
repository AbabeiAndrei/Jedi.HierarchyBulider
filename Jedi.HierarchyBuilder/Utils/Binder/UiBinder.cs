using System;
using System.Collections;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Collections.Generic;
using Jedi.HierarchyBuilder.Utils.Binder.Specific;

namespace Jedi.HierarchyBuilder.Utils.Binder
{
    public delegate void BinderEventHandler(IBinder sender, EventArgs args);

    public class UiBinder : IBinder, IBinderTracker, IEnumerable<IBinder>
    {
        #region Fields

        private readonly IList<IBinder> _binders;

        private int _binderTrackerPosition;
        private IList<BinderTrackerValue> _bindersTracker;
        private bool _isInUndoProcess;
        private bool _isInRedoProcess;
        
        #endregion

        #region Events

        public event BinderEventHandler BindValueChange;

        #endregion

        #region Constructors

        public UiBinder()
        {
            _binders = new List<IBinder>();
            _binderTrackerPosition = -1;
            _bindersTracker = new List<BinderTrackerValue>();
        }

        #endregion

        #region Implementation of IBinderBundle

        public void Set()
        {
            foreach (var binder in _binders)
            {
                binder.Set();
            }
        }

        #endregion

        #region Implementation of IBinderTracker

        /* !!!! IMPORTANT !!!
         * 
         * Undo capabilites not working, for the moment
         * Maybe some day, will work.
         * Pacience is the key
         * */

        /// <inheritdoc />
        public bool HaveChanges => _bindersTracker.Count > 0;

        /// <summary>
        /// Gets if the last acction can be undo
        /// </summary>
        public bool CanUndo => _binderTrackerPosition > 0 && _bindersTracker.Count > 0;

        /// <summary>
        /// Gets if the previosly undo-ed (undone-it... yeah) can be done it... again... english is weird
        /// </summary>
        public bool CanRedo => _binderTrackerPosition < _bindersTracker.Count - 1 && _bindersTracker.Count > 0;

        /// <inheritdoc />
        public void Undo()
        {
            if(_binderTrackerPosition <= 0 || _bindersTracker.Count <= 0)
                return;

            var position = --_binderTrackerPosition;

            var track = _bindersTracker[position];

            try
            {
                _isInUndoProcess = true;
                track.Binder.SetValue(track.Value);
            }
            finally
            {
                _isInUndoProcess = false;
            }
        }

        /// <inheritdoc />
        public void Redo()
        {
            if (_bindersTracker.Count <= 0 || _binderTrackerPosition >= _bindersTracker.Count-1)
                return;

            var position = ++_binderTrackerPosition;

            var track = _bindersTracker[position];

            try
            {
                _isInRedoProcess = true;
                track.Binder.SetValue(track.Value);
            }
            finally
            {
                _isInRedoProcess = false;
            }
        }

        public void Clear()
        {
            _bindersTracker.Clear();
            _binderTrackerPosition = -1;
        }

        #endregion

        #region Implementation of IEnumerable

        /// <inheritdoc />
        public IEnumerator<IBinder> GetEnumerator()
        {
            return _binders.GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Public methods
        
        public IBinder<string> Add<TSource>(TextBox textBox,
                                            Func<TSource> entityGetter,
                                            Expression<Func<TSource, string>> resultSelector)
        {
            var binder = new TextboxBinder<TSource>(entityGetter, resultSelector);

            binder.Bind(textBox);

            _binders.Add(binder);
            binder.OnChanged += AddToTrackerHandler;
            binder.OnChanged += (sender, args) => BindValueChange?.Invoke(sender, EventArgs.Empty);

            return binder;
        }

        public IBinder<bool> Add<TSource>(CheckBox checkBox,
                                          Func<TSource> entityGetter,
                                          Expression<Func<TSource, bool>> resultSelector)
        {
            var binder = new CheckboxBinder<TSource>(entityGetter, resultSelector);

            binder.Bind(checkBox);

            _binders.Add(binder);
            binder.OnChanged += AddToTrackerHandler;
            binder.OnChanged += (sender, args) => BindValueChange?.Invoke(sender, EventArgs.Empty);

            return binder;
        }

        public IBinder<int> Add<TSource>(NumericUpDown numericUpDown,
                                         Func<TSource> entityGetter,
                                         Expression<Func<TSource, int>> resultSelector)
        {
            var binder = new NumericBinder<TSource>(entityGetter, resultSelector);

            binder.Bind(numericUpDown);

            _binders.Add(binder);
            binder.OnChanged += AddToTrackerHandler;
            binder.OnChanged += (sender, args) => BindValueChange?.Invoke(sender, EventArgs.Empty);

            return binder;
        }

        public IBinder<TResult> Add<TSource, TResult>(ComboBox comboBox,
                                                      Func<TSource> entityGetter,
                                                      Expression<Func<TSource, TResult>> resultSelector)
        {
            var binder = new ComboboxBinder<TSource,TResult>(entityGetter, resultSelector);

            binder.Bind(comboBox);

            _binders.Add(binder);
            binder.OnChanged += AddToTrackerHandler;
            binder.OnChanged += (sender, args) => BindValueChange?.Invoke(sender, EventArgs.Empty);

            return binder;
        }

        #endregion

        #region Protected methods

        protected void AddToTrackerHandler<TResult>(IBinder sender, BinderValueChangedArgs<TResult> args)
        {
            if (_isInUndoProcess || _isInRedoProcess)    //ignore changes stated by Undo/Redo
                return;

            if (_binderTrackerPosition > -1 && _binderTrackerPosition < _bindersTracker.Count - 1)
            {
                _bindersTracker = _bindersTracker.Splice(_binderTrackerPosition);
            }

            var addNewBindTracker = true;

            if (_bindersTracker.Count > 0)
            {
                var last = _bindersTracker[_bindersTracker.Count - 1];
                if (last.Binder.Equals(sender)) //if last binder is the same with the current binder
                {
                    last.Value = args.Value;
                    addNewBindTracker = false;
                }
            }
            if (addNewBindTracker)
            {
                _bindersTracker.Add(new BinderTrackerValue(sender, args.Value));
                _binderTrackerPosition++;
            }
        }

        #endregion
    }

    public class UiBinder<TSource> : UiBinder
    {
        #region Fields

        private readonly Func<TSource> _entity;

        #endregion

        #region Constructor

        public UiBinder(Func<TSource> entity)
        {
            _entity = entity;
        }

        #endregion

        #region Public methods

        public IBinder<string> Add(TextBox textBox, Expression<Func<TSource, string>> resultSelector)
        {
            return Add(textBox, _entity, resultSelector);
        }

        public IBinder<bool> Add(CheckBox checkBox, Expression<Func<TSource, bool>> resultSelector)
        {
            return Add(checkBox, _entity, resultSelector);
        }

        public IBinder<int> Add(NumericUpDown numericUpDown, Expression<Func<TSource, int>> resultSelector)
        {
            return Add(numericUpDown, _entity, resultSelector);
        }

        public IBinder<TResult> Add<TResult>(ComboBox comboBox, Expression<Func<TSource, TResult>> resultSelector)
        {
            return Add(comboBox, _entity, resultSelector);
        }

        #endregion
    }

    public class BinderTrackerValue
    {
        #region Properties

        public IBinder Binder { get; set; }

        public object Value { get; set; }
        
        #endregion

        #region Constructors

        public BinderTrackerValue(IBinder binder, object value)
        {
            Binder = binder;
            Value = value;
        }

        #endregion
    }
}
