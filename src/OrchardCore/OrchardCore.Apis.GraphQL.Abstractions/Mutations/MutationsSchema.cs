using System.Collections.Generic;
using GraphQL.Types;
using OrchardCore.Apis.GraphQL.Types;

namespace OrchardCore.Apis.GraphQL.Mutations
{
    public class MutationsSchema : ObjectGraphType
    {
        public MutationsSchema(IEnumerable<MutationFieldType> fields)
        {
            Name = "Mutations";

            foreach (var field in fields)
            {
                AddField(field);
            }
        }
    }
}
