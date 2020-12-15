namespace DesignPatterns.TemplateMethodPattern
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrial;

        protected Task()
        {
            _auditTrial = new AuditTrail();
        }

        protected Task(AuditTrail trail)
        {
            _auditTrial = trail;
        }

        public virtual void Execute()
        {
            _auditTrial.Record();

            doExecute();
        }

        protected abstract void doExecute();
    }
}
