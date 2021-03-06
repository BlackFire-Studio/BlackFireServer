﻿//----------------------------------------------------
//Copyright © 2008-2018 Mr-Alan. All rights reserved.
//Mail: Mr.Alan.China@[outlook|gmail].com
//Website: www.0x69h.com
//----------------------------------------------------

using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace BlackFireServer.Server.Business
{
    public class BusinessServer : AppServer<BusinessServerSession,BusinessServerRequestInfo>
    {
        public BusinessServer() : base(new DefaultReceiveFilterFactory<BusinessServerReceiveFilter,BusinessServerRequestInfo>()) { }
    }
}
