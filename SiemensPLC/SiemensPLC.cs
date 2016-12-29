using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensPLC
{ 
    class SiemensPLC
    {
      
        public static libnodave.daveOSserialType fds;//declaration connection type
        public static libnodave.daveInterface di;//declaration of connection interface
        public static libnodave.daveConnection dc;//declaration of connection
        
        public static int res;//declaration of res value for function return
        public static byte plcValue;//declaration of plcValue to read from plc its a byte in this case
        public static int memoryRes;//declaration of memory for ReadyBytes function return
        public static byte[] memoryBuffer = new byte[10];//declaration of an byte array with 10 bytes value
        //let's the connect function
        public static void connectTo()
        {
            
            fds.rfd = libnodave.openSocket(102,"192.168.0.15");//connect to PLC with IP address
            fds.wfd = fds.rfd;
            di = new libnodave.daveInterface(fds, "IF1", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
            res = di.initAdapter();
            dc = new libnodave.daveConnection(di, 0, 0, 2);
            res = dc.connectPLC();
            memoryRes = dc.readBytes(libnodave.daveFlags, 0, 0, 1, memoryBuffer);//read a buffer of 1 bytesand pu it on memoryBufer variable
            plcValue = memoryBuffer[0];//put memoryBuffer byte value on plcValue variable
            dc.disconnectPLC();//diconnect PLC
            di.disconnectAdapter();//diconnect Aadapter
            libnodave.closePort(fds.rfd);//close connection

        }

    }
}
