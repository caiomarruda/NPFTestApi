using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NPFTestApi.Core.Models
{
    public class Notification
    {
        private readonly IList<string> _messages = new List<string>();

        public IEnumerable<string> Errors { get; }
        public object Result { get; }

        public Notification() => Errors = new ReadOnlyCollection<string>(_messages);

        public Notification(object result) : this() => Result = result;

        public Notification AddError(string message)
        {
            _messages.Add(message);
            return this;
        }
    }
}
