//  Copyright © 2021 by Threshold Secrets Llc.
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.


using Goedel.Protocol;
using Goedel.Presence;
using Goedel.Protocol.Presentation;
using Goedel.Utilities;
using Goedel.Mesh.ServiceAdmin;

using System.Collections.Generic;
namespace Goedel.Presence.Server {




    /// <summary>
    /// The session class implements the Mesh session. The implementations in this class are mostly 
    /// stubbs that martial and validate the parameters presented in the request and pass the
    /// work on to the <see cref="MeshPersist"/> instance <see cref="Mesh"/>
    /// </summary>
    public class PublicPresenceService : PresenceService {


        /// <summary>
        /// Factory method, the signature is pro tem and will be changed later on.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="serviceDirectory"></param>
        /// <returns></returns>
        public static Goedel.Protocol.JpcInterface Factory(ServiceConfiguration serviceConfiguration,
            HostConfiguration hostConfiguration) => throw new NYI();
        public override QueryResponse Query(QueryRequest request, IJpcSession session) => throw new System.NotImplementedException();

        public static ServiceDescription ServiceDescription => new(WellKnown, Factory);

        }
    }
