//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debugging.Tests {
    
    
    public partial class Where {
        
        /// <summary>
        /// Query helper for member Where.NHQGWithARMany
        /// </summary>
        public static Root_Query_NHQGWithARMany NHQGWithARMany {
            get {
                return new Root_Query_NHQGWithARMany();
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Query_NHQGWithARMany
        /// </summary>
        public partial class Query_NHQGWithARMany<T1> : Query.QueryBuilder<T1>
         {
            
            /// <summary>
            /// Query helper for member Query_NHQGWithARMany..ctor
            /// </summary>
            public Query_NHQGWithARMany(string name, string associationPath) : 
                    base(name, associationPath) {
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithARMany..ctor
            /// </summary>
            public Query_NHQGWithARMany(string name, string associationPath, bool backTrackAssociationOnEquality) : 
                    base(name, associationPath, backTrackAssociationOnEquality) {
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithARMany.
            /// </summary>
            public virtual Query.PropertyQueryBuilder<T1> Name {
                get {
                    string temp = associationPath;
                    return new Query.PropertyQueryBuilder<T1>("Name", temp);
                }
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithARMany.
            /// </summary>
            public virtual Query.QueryBuilder<T1> Id {
                get {
                    string temp = associationPath;
                    return new Query.QueryBuilder<T1>("Id", temp);
                }
            }
            
            /// <summary>
            /// Query helper for member Query_NHQGWithARMany.
            /// </summary>
            public virtual Query_NHQGWithAROne<T1> NHQGWithAROne {
                get {
                    string temp = associationPath;
                    temp = ((temp + ".") 
                                + "NHQGWithAROne");
                    return new Query_NHQGWithAROne<T1>("NHQGWithAROne", temp, true);
                }
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Root_Query_NHQGWithARMany
        /// </summary>
        public partial class Root_Query_NHQGWithARMany : Query_NHQGWithARMany<Debugging.Tests.NHQGWithARMany> {
            
            /// <summary>
            /// Query helper for member Root_Query_NHQGWithARMany..ctor
            /// </summary>
            public Root_Query_NHQGWithARMany() : 
                    base("this", null) {
            }
        }
    }
    
    public partial class OrderBy {
        
        /// <summary>
        /// Query helper for member OrderBy.NHQGWithARMany
        /// </summary>
        public partial class NHQGWithARMany {
            
            /// <summary>
            /// Query helper for member NHQGWithARMany.Name
            /// </summary>
            public static Query.OrderByClause Name {
                get {
                    return new Query.OrderByClause("Name");
                }
            }
            
            /// <summary>
            /// Query helper for member NHQGWithARMany.Id
            /// </summary>
            public static Query.OrderByClause Id {
                get {
                    return new Query.OrderByClause("Id");
                }
            }
        }
    }
    
    public partial class ProjectBy {
        
        /// <summary>
        /// Query helper for member ProjectBy.NHQGWithARMany
        /// </summary>
        public partial class NHQGWithARMany {
            
            /// <summary>
            /// Query helper for member NHQGWithARMany.Name
            /// </summary>
            public static Query.PropertyProjectionBuilder Name {
                get {
                    return new Query.PropertyProjectionBuilder("Name");
                }
            }
        }
    }
    
    public partial class GroupBy {
        
        /// <summary>
        /// Query helper for member GroupBy.NHQGWithARMany
        /// </summary>
        public partial class NHQGWithARMany {
            
            /// <summary>
            /// Query helper for member NHQGWithARMany.Name
            /// </summary>
            public static NHibernate.Expression.IProjection Name {
                get {
                    return NHibernate.Expression.Projections.GroupProperty("Name");
                }
            }
        }
    }
}