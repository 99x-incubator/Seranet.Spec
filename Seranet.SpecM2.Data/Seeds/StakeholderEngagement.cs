using Seranet.SpecM2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seranet.SpecM2.Data.Seeds
{
    class StakeholderEngagement
    {
        private Area se;

        public StakeholderEngagement(Level[] levels)
        {
            Level level1 = levels[0];
            Level level2 = levels[1];
            Level level3 = levels[2];
            se = new Area
            {
                GUID = Guid.NewGuid(),
                Name = "Engagement Strength",
                Description = "todo",
                SubAreas = new List<SubArea> {
                        new SubArea{ GUID=Guid.NewGuid(), Code="RM", Name="Relationship Management", 
                            Practices= new List<Practice> {
                                new Practice{ GUID=Guid.NewGuid(), Code="RM.1.1", Description="Team knows the onsite counterparts in person and maintains a good social engagement over digital media.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="RM.1.2", Description="99XT representative keeps contact with the product owner regularly to get a pulse of the project delivery.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="RM.2.1", Description="Distributed teams physically meet each other regularly.", Level = level2},
                                new Practice{ GUID=Guid.NewGuid(), Code="RM.2.2", Description="Team get engaged in discussing potential business strategies of teh ISV outside the given work scope.", Level = level2},
                                new Practice{ GUID=Guid.NewGuid(), Code="RM.3.1", Description="Mechanisms are in place to provide direct feedback to other co-teams from the 99XT team.", Level = level3},
                                new Practice{ GUID=Guid.NewGuid(), Code="RM.3.2", Description="TTeam maintains an acceptable customer satisfaction rating with an upward trend.", Level = level3}
                            }
                        },
                        new SubArea{ GUID=Guid.NewGuid(), Code="PA", Name="Product Assistance", 
                            Practices= new List<Practice> {
                                new Practice{ GUID=Guid.NewGuid(), Code="PA.1.1", Description="All team members are able to explain the technical details of the complete release cycle of the product (from code commits to end-user delivery).", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="PA.1.2", Description="Team takes part in launching procedures of the new market releases and participates in celebrations with the onsite counterparts.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="PA.2.1", Description="Team is aware of the competitive products in the market and comparative strengths/weaknesses.", Level = level2},
                                new Practice{ GUID=Guid.NewGuid(), Code="PA.3.1", Description="Team is supportive in preparing and distributing product marketing material such as promotional videos, social media posts, etc.", Level = level3},
                                new Practice{ GUID=Guid.NewGuid(), Code="PA.3.2", Description="Team contributes to the technical goodwill of the ISV through relevant industrial activities such as maintaining a team blog, contributing to open source, etc.", Level = level3}
                            }
                        },
                        new SubArea{ GUID=Guid.NewGuid(), Code="SI", Name="Service Introduction", 
                            Practices= new List<Practice> {
                                new Practice{ GUID=Guid.NewGuid(), Code="SI.1.1", Description="Product owners and onsite decision makers are aware of the value added service portfolio offered by 99X Technology.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="SI.2.1", Description="Team keeps continuous dialogues with specialized service teams to identify possible value addition to the product.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="SI.2.2", Description="Proof of concept work is done to identify applicability of at least two additional services.", Level = level2},
                                new Practice{ GUID=Guid.NewGuid(), Code="SI.3.1", Description="Apart from core services team has utilized other additional services from 99X Technology in the project.", Level = level3},
                            }
                        },
                       new SubArea{ GUID=Guid.NewGuid(), Code="OS", Name="Organizational Sharing", 
                            Practices= new List<Practice> {
                                new Practice{ GUID=Guid.NewGuid(), Code="OS.1.1", Description="Takes part in interest groups that uses similar technologies. Assist other teams with technology expertise and reviews.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="OS.1.2", Description="Contribute with knowledge sharing posts in company social media such as blogs, yammer, etc.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="OS.2.1", Description="Conduct tech sessions within the company covering something that the team can share from the project.", Level = level2},
                                new Practice{ GUID=Guid.NewGuid(), Code="OS.3.1", Description="Contribute with knowledge articles in corporate wiki, preferably on organizational specific procedures, practices and guidelines.", Level = level3},
                            }
                        },
                        new SubArea{ GUID=Guid.NewGuid(), Code="CS", Name="Community Sharing", 
                            Practices= new List<Practice> {
                                new Practice{ GUID=Guid.NewGuid(), Code="CS.1.1", Description="All team members actively maintain their linkedIn profiles.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="CS.1.2", Description="Majority of the members maintains a blog having activities during the period of last 6 months.", Level = level1},
                                new Practice{ GUID=Guid.NewGuid(), Code="CS.2.1", Description="Team members should be active in tech/business forums with an increasing reputation.", Level = level2},
                                new Practice{ GUID=Guid.NewGuid(), Code="CS.2.2", Description="Team members have contributed as resource personnel in initiatives that engage with external parties.", Level = level2},
                                new Practice{ GUID=Guid.NewGuid(), Code="CS.3.1", Description="Team members contribute to external technological initiatives such as open source development. ", Level = level3},
                                new Practice{ GUID=Guid.NewGuid(), Code="CS.3.2", Description="Team members have participated in industrial sessions, meetups, seminars, etc. as speakers.", Level = level3}
                            }
                        },
                    }
            };
        }

        public Area Area 
        {
            get 
            {
                return se;
            }
        }
    }
}
