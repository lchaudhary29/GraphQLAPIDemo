using GraphQL.Types;
using GraphQL.Utilities;
using GraphQLAPIDemo.GraphQL.GraphQLQueries;
using System;

namespace GraphQLAPIDemo.GraphQL.GraphQLSchema
{

    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider services) : base(services)
        {
            Query = services.GetRequiredService<AppQuery>();
            Mutation = services.GetRequiredService<AppMutation>();
        }
    }
}
