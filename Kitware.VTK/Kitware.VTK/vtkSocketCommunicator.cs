using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSocketCommunicator : vtkCommunicator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSocketCommunicator";

		public new static readonly string MRClassNameKey;

		static vtkSocketCommunicator()
		{
			vtkSocketCommunicator.MRClassNameKey = "class vtkSocketCommunicator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSocketCommunicator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocketCommunicator"));
		}

		public vtkSocketCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketCommunicator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSocketCommunicator New()
		{
			vtkSocketCommunicator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketCommunicator.vtkSocketCommunicator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSocketCommunicator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSocketCommunicator.vtkSocketCommunicator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_AllGatherVVoidArray_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type);

		public override int AllGatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_AllGatherVVoidArray_01(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_AllGatherVoidArray_02(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type);

		public override int AllGatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_AllGatherVoidArray_02(base.GetCppThis(), sendBuffer, recvBuffer, length, type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_AllReduceVoidArray_03(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation);

		public override int AllReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_AllReduceVoidArray_03(base.GetCppThis(), sendBuffer, recvBuffer, length, type, operation);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketCommunicator_Barrier_04(HandleRef pThis);

		public override void Barrier()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_Barrier_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_BroadcastVoidArray_05(HandleRef pThis, IntPtr data, long length, int type, int srcProcessId);

		public override int BroadcastVoidArray(IntPtr data, long length, int type, int srcProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_BroadcastVoidArray_05(base.GetCppThis(), data, length, type, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_ClientSideHandshake_06(HandleRef pThis);

		public int ClientSideHandshake()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ClientSideHandshake_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketCommunicator_CloseConnection_07(HandleRef pThis);

		public virtual void CloseConnection()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_CloseConnection_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_ConnectTo_08(HandleRef pThis, string hostName, int port);

		public virtual int ConnectTo(string hostName, int port)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ConnectTo_08(base.GetCppThis(), hostName, port);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GatherVVoidArray_09(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId);

		public override int GatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GatherVVoidArray_09(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GatherVoidArray_10(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId);

		public override int GatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GatherVoidArray_10(base.GetCppThis(), sendBuffer, recvBuffer, length, type, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GetIsConnected_11(HandleRef pThis);

		public int GetIsConnected()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetIsConnected_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GetIsServer_12(HandleRef pThis);

		public virtual int GetIsServer()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetIsServer_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GetPerformHandshake_13(HandleRef pThis);

		public virtual int GetPerformHandshake()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetPerformHandshake_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GetPerformHandshakeMaxValue_14(HandleRef pThis);

		public virtual int GetPerformHandshakeMaxValue()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetPerformHandshakeMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GetPerformHandshakeMinValue_15(HandleRef pThis);

		public virtual int GetPerformHandshakeMinValue()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetPerformHandshakeMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GetReportErrors_16(HandleRef pThis);

		public virtual int GetReportErrors()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetReportErrors_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketCommunicator_GetSocket_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkClientSocket GetSocket()
		{
			vtkClientSocket vtkClientSocket = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketCommunicator.vtkSocketCommunicator_GetSocket_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClientSocket = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClientSocket.Register(null);
				}
			}
			return vtkClientSocket;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_GetSwapBytesInReceivedData_18(HandleRef pThis);

		public virtual int GetSwapBytesInReceivedData()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_GetSwapBytesInReceivedData_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_Handshake_19(HandleRef pThis);

		public int Handshake()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_Handshake_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_LogToFile_22(HandleRef pThis, string name);

		public virtual int LogToFile(string name)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_LogToFile_22(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_LogToFile_23(HandleRef pThis, string name, int append);

		public virtual int LogToFile(string name, int append)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_LogToFile_23(base.GetCppThis(), name, append);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketCommunicator_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSocketCommunicator NewInstance()
		{
			vtkSocketCommunicator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketCommunicator.vtkSocketCommunicator_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketCommunicator_PerformHandshakeOff_26(HandleRef pThis);

		public virtual void PerformHandshakeOff()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_PerformHandshakeOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketCommunicator_PerformHandshakeOn_27(HandleRef pThis);

		public virtual void PerformHandshakeOn()
		{
			vtkSocketCommunicator.vtkSocketCommunicator_PerformHandshakeOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_ReceiveVoidArray_28(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		public override int ReceiveVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ReceiveVoidArray_28(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_ReduceVoidArray_29(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId);

		public override int ReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ReduceVoidArray_29(base.GetCppThis(), sendBuffer, recvBuffer, length, type, operation, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSocketCommunicator_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSocketCommunicator SafeDownCast(vtkObjectBase o)
		{
			vtkSocketCommunicator vtkSocketCommunicator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocketCommunicator.vtkSocketCommunicator_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocketCommunicator = (vtkSocketCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocketCommunicator.Register(null);
				}
			}
			return vtkSocketCommunicator;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_ScatterVVoidArray_31(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId);

		public override int ScatterVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ScatterVVoidArray_31(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, type, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_ScatterVoidArray_32(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId);

		public override int ScatterVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ScatterVoidArray_32(base.GetCppThis(), sendBuffer, recvBuffer, length, type, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_SendVoidArray_33(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		public override int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_SendVoidArray_33(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_ServerSideHandshake_34(HandleRef pThis);

		public int ServerSideHandshake()
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_ServerSideHandshake_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketCommunicator_SetNumberOfProcesses_35(HandleRef pThis, int num);

		public override void SetNumberOfProcesses(int num)
		{
			vtkSocketCommunicator.vtkSocketCommunicator_SetNumberOfProcesses_35(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketCommunicator_SetPerformHandshake_36(HandleRef pThis, int _arg);

		public virtual void SetPerformHandshake(int _arg)
		{
			vtkSocketCommunicator.vtkSocketCommunicator_SetPerformHandshake_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketCommunicator_SetReportErrors_37(HandleRef pThis, int _arg);

		public virtual void SetReportErrors(int _arg)
		{
			vtkSocketCommunicator.vtkSocketCommunicator_SetReportErrors_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSocketCommunicator_SetSocket_38(HandleRef pThis, HandleRef arg0);

		public void SetSocket(vtkClientSocket arg0)
		{
			vtkSocketCommunicator.vtkSocketCommunicator_SetSocket_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_WaitForConnection_39(HandleRef pThis, int port);

		public virtual int WaitForConnection(int port)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_WaitForConnection_39(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSocketCommunicator_WaitForConnection_40(HandleRef pThis, HandleRef socket, uint msec);

		public virtual int WaitForConnection(vtkServerSocket socket, uint msec)
		{
			return vtkSocketCommunicator.vtkSocketCommunicator_WaitForConnection_40(base.GetCppThis(), (socket == null) ? default(HandleRef) : socket.GetCppThis(), msec);
		}
	}
}
