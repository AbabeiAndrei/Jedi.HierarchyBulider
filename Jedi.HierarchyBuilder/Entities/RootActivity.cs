using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Entities
{
    public class RootActivity : IValidatable
    {
        #region Properties

        public IEnumerable<LearningActivity> RootActivities { get; set; }

        public string TemplateUsername { get; set; }

        public bool CreateParticipants { get; set; }

        public bool CreateUserAuthorization { get; set; }

        public bool ExtractProviderPackage { get; set; }

        #endregion

        #region Implementation of IValidatable

        public IReadOnlyCollection<Exception> Validate()
        {
            var errors = new List<Exception>();
            if(string.IsNullOrWhiteSpace(TemplateUsername))
                errors.Add(new Exception($"{nameof(TemplateUsername)} cannot be null or empty"));

            
            errors.AddRange(ValidateActivities(RootActivities));

            return errors;
        }

        private IEnumerable<Exception> ValidateActivities(IEnumerable<LearningActivity> learningActivities)
        {
            return learningActivities.SelectMany(ValidateActivity);
        }

        private IEnumerable<Exception> ValidateActivity(LearningActivity activity)
        {
            if(string.IsNullOrEmpty(activity.Name))
                yield return new Exception($"{nameof(activity.Name)} cannot be empty");

            if (activity.IsActivity)
            {
                if (string.IsNullOrEmpty(activity.TinCan_Id))
                    yield return new Exception($"{nameof(activity.TinCan_Id)} cannot be empty");

                if (string.IsNullOrEmpty(activity.TinCan_StartupFile))
                    yield return new Exception($"{nameof(activity.TinCan_StartupFile)} cannot be empty");
            }
            else
            {
                foreach (var error in ValidateActivities(activity.Members))
                {
                    yield return error;
                }
            }
        }

        #endregion
    }
}

