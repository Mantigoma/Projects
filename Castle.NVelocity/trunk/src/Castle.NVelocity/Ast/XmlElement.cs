// Copyright 2007 Jonathon Rossi - http://www.jonorossi.com/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.NVelocity.Ast
{
    using System.Collections.Generic;

    public class XmlElement : AstNode
    {
        private string _name;
        private bool _isSelfClosing = false;
        private List<AstNode> _attributes = new List<AstNode>();
        private List<AstNode> _content = new List<AstNode>();

        private Position _startTagPosition;
        private Position _endTagPosition; // null if self closing

        public XmlElement(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public bool IsSelfClosing
        {
            get { return _isSelfClosing; }
            set { _isSelfClosing = value; }
        }

        public List<AstNode> Attributes
        {
            get { return _attributes; }
        }

        public List<AstNode> Content
        {
            get { return _content; }
        }

        public Position StartTagPosition
        {
            get { return _startTagPosition; }
            set { _startTagPosition = value; }
        }

        public Position EndTagPosition
        {
            get { return _endTagPosition; }
            set { _endTagPosition = value; }
        }
    }
}
