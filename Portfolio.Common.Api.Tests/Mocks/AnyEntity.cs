using Portfolio.Common.Api.BaseEntities;

namespace Portfolio.Common.Api.Tests.Mocks
{
    public class AnyEntity : BaseEntity
    {
        public string AnyString { get; set; }

        public override void Copy(BaseEntity other)
        {
            AnyEntity otherEntity = other as AnyEntity;
            AnyString = otherEntity.AnyString;
        }
    }
}
