using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Isometric.Obsoletes
{
    [Obsolete]
    class TestConsoleWriter : Observer
    {
        public TestConsoleWriter()
        {
            //subjectPool.GetSubject((int)SubjectPoolSpots.InputHandler).Subscribe(this);
        }

        public void Update()
        {

        }
    }
}
