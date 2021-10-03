namespace TemplateMethodPattern.Solution
{
    public abstract class Task
    {
        private readonly AuditTrail auditTrail;

        public Task()
        {
            auditTrail = new AuditTrail();
        }
        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
