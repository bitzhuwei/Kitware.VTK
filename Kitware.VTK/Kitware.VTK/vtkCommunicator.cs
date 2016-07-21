using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkCommunicator : vtkObject
	{
		public enum StandardOperations
		{
			BITWISE_AND_OP = 5,
			BITWISE_OR_OP = 7,
			BITWISE_XOR_OP = 9,
			LOGICAL_AND_OP = 4,
			LOGICAL_OR_OP = 6,
			LOGICAL_XOR_OP = 8,
			MAX_OP = 0,
			MIN_OP,
			PRODUCT_OP = 3,
			SUM_OP = 2
		}

		public enum Tags
		{
			BARRIER_TAG = 16,
			BROADCAST_TAG = 10,
			GATHERV_TAG = 12,
			GATHER_TAG = 11,
			REDUCE_TAG = 15,
			SCATTERV_TAG = 14,
			SCATTER_TAG = 13
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkCommunicator";

		public new static readonly string MRClassNameKey;

		static vtkCommunicator()
		{
			vtkCommunicator.MRClassNameKey = "class vtkCommunicator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCommunicator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommunicator"));
		}

		public vtkCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGather_01(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length);

		public int AllGather(IntPtr sendBuffer, IntPtr recvBuffer, long length)
		{
			return vtkCommunicator.vtkCommunicator_AllGather_01(base.GetCppThis(), sendBuffer, recvBuffer, length);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGather_02(HandleRef pThis, string sendBuffer, string recvBuffer, long length);

		public int AllGather(string sendBuffer, string recvBuffer, long length)
		{
			return vtkCommunicator.vtkCommunicator_AllGather_02(base.GetCppThis(), sendBuffer, recvBuffer, length);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGather_03(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		public int AllGather(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
		{
			return vtkCommunicator.vtkCommunicator_AllGather_03(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGatherV_04(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

		public int AllGatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherV_04(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGatherV_05(HandleRef pThis, string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets);

		public int AllGatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherV_05(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGatherV_06(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets);

		public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherV_06(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), recvLengths, offsets);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGatherV_07(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer);

		public int AllGatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherV_07(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGatherVVoidArray_08(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type);

		public virtual int AllGatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherVVoidArray_08(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllGatherVoidArray_09(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type);

		public virtual int AllGatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type)
		{
			return vtkCommunicator.vtkCommunicator_AllGatherVoidArray_09(base.GetCppThis(), sendBuffer, recvBuffer, length, type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllReduce_10(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation);

		public int AllReduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation)
		{
			return vtkCommunicator.vtkCommunicator_AllReduce_10(base.GetCppThis(), sendBuffer, recvBuffer, length, operation);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllReduce_11(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int operation);

		public int AllReduce(string sendBuffer, string recvBuffer, long length, int operation)
		{
			return vtkCommunicator.vtkCommunicator_AllReduce_11(base.GetCppThis(), sendBuffer, recvBuffer, length, operation);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllReduce_12(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation);

		public int AllReduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation)
		{
			return vtkCommunicator.vtkCommunicator_AllReduce_12(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), operation);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_AllReduceVoidArray_13(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation);

		public virtual int AllReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation)
		{
			return vtkCommunicator.vtkCommunicator_AllReduceVoidArray_13(base.GetCppThis(), sendBuffer, recvBuffer, length, type, operation);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCommunicator_Barrier_14(HandleRef pThis);

		public virtual void Barrier()
		{
			vtkCommunicator.vtkCommunicator_Barrier_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Broadcast_15(HandleRef pThis, IntPtr data, long length, int srcProcessId);

		public int Broadcast(IntPtr data, long length, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Broadcast_15(base.GetCppThis(), data, length, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Broadcast_16(HandleRef pThis, string data, long length, int srcProcessId);

		public int Broadcast(string data, long length, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Broadcast_16(base.GetCppThis(), data, length, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Broadcast_17(HandleRef pThis, HandleRef data, int srcProcessId);

		public int Broadcast(vtkDataObject data, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Broadcast_17(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Broadcast_18(HandleRef pThis, HandleRef data, int srcProcessId);

		public int Broadcast(vtkDataArray data, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Broadcast_18(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_BroadcastVoidArray_19(HandleRef pThis, IntPtr data, long length, int type, int srcProcessId);

		public virtual int BroadcastVoidArray(IntPtr data, long length, int type, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_BroadcastVoidArray_19(base.GetCppThis(), data, length, type, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Gather_20(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId);

		public int Gather(IntPtr sendBuffer, IntPtr recvBuffer, long length, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Gather_20(base.GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Gather_21(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int destProcessId);

		public int Gather(string sendBuffer, string recvBuffer, long length, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Gather_21(base.GetCppThis(), sendBuffer, recvBuffer, length, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Gather_22(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		public int Gather(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Gather_22(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GatherV_23(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		public int GatherV(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_23(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GatherV_24(HandleRef pThis, string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		public int GatherV(string sendBuffer, string recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_24(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GatherV_25(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId);

		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, IntPtr recvLengths, IntPtr offsets, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_25(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), recvLengths, offsets, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GatherV_26(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int destProcessId);

		public int GatherV(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherV_26(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GatherVVoidArray_27(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId);

		public virtual int GatherVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long sendLength, IntPtr recvLengths, IntPtr offsets, int type, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherVVoidArray_27(base.GetCppThis(), sendBuffer, recvBuffer, sendLength, recvLengths, offsets, type, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GatherVoidArray_28(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId);

		public virtual int GatherVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_GatherVoidArray_28(base.GetCppThis(), sendBuffer, recvBuffer, length, type, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern long vtkCommunicator_GetCount_29(HandleRef pThis);

		public virtual long GetCount()
		{
			return vtkCommunicator.vtkCommunicator_GetCount_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GetLeftChildProcessor_30(int pid);

		public static int GetLeftChildProcessor(int pid)
		{
			return vtkCommunicator.vtkCommunicator_GetLeftChildProcessor_30(pid);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GetLocalProcessId_31(HandleRef pThis);

		public virtual int GetLocalProcessId()
		{
			return vtkCommunicator.vtkCommunicator_GetLocalProcessId_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GetNumberOfProcesses_32(HandleRef pThis);

		public virtual int GetNumberOfProcesses()
		{
			return vtkCommunicator.vtkCommunicator_GetNumberOfProcesses_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_GetParentProcessor_33(int pid);

		public static int GetParentProcessor(int pid)
		{
			return vtkCommunicator.vtkCommunicator_GetParentProcessor_33(pid);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_IsA_34(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCommunicator.vtkCommunicator_IsA_34(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_IsTypeOf_35(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCommunicator.vtkCommunicator_IsTypeOf_35(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_MarshalDataObject_36(HandleRef arg0, HandleRef buffer);

		public static int MarshalDataObject(vtkDataObject arg0, vtkCharArray buffer)
		{
			return vtkCommunicator.vtkCommunicator_MarshalDataObject_36((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (buffer == null) ? default(HandleRef) : buffer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCommunicator_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCommunicator NewInstance()
		{
			vtkCommunicator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCommunicator.vtkCommunicator_NewInstance_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Receive_38(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

		public int Receive(vtkDataObject data, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Receive_38(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Receive_39(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

		public int Receive(vtkDataArray data, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Receive_39(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Receive_40(HandleRef pThis, IntPtr data, long maxlength, int remoteHandle, int tag);

		public int Receive(IntPtr data, long maxlength, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Receive_40(base.GetCppThis(), data, maxlength, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Receive_41(HandleRef pThis, string data, long maxlength, int remoteHandle, int tag);

		public int Receive(string data, long maxlength, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Receive_41(base.GetCppThis(), data, maxlength, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCommunicator_ReceiveDataObject_42(HandleRef pThis, int remoteHandle, int tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject ReceiveDataObject(int remoteHandle, int tag)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCommunicator.vtkCommunicator_ReceiveDataObject_42(base.GetCppThis(), remoteHandle, tag, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_ReceiveVoidArray_43(HandleRef pThis, IntPtr data, long maxlength, int type, int remoteHandle, int tag);

		public virtual int ReceiveVoidArray(IntPtr data, long maxlength, int type, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_ReceiveVoidArray_43(base.GetCppThis(), data, maxlength, type, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Reduce_44(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId);

		public int Reduce(IntPtr sendBuffer, IntPtr recvBuffer, long length, int operation, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Reduce_44(base.GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Reduce_45(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int operation, int destProcessId);

		public int Reduce(string sendBuffer, string recvBuffer, long length, int operation, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Reduce_45(base.GetCppThis(), sendBuffer, recvBuffer, length, operation, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Reduce_46(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int operation, int destProcessId);

		public int Reduce(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int operation, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Reduce_46(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), operation, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_ReduceVoidArray_47(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId);

		public virtual int ReduceVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int operation, int destProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ReduceVoidArray_47(base.GetCppThis(), sendBuffer, recvBuffer, length, type, operation, destProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCommunicator_SafeDownCast_48(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCommunicator SafeDownCast(vtkObjectBase o)
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCommunicator.vtkCommunicator_SafeDownCast_48((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommunicator = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommunicator.Register(null);
				}
			}
			return vtkCommunicator;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Scatter_49(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId);

		public int Scatter(IntPtr sendBuffer, IntPtr recvBuffer, long length, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Scatter_49(base.GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Scatter_50(HandleRef pThis, string sendBuffer, string recvBuffer, long length, int srcProcessId);

		public int Scatter(string sendBuffer, string recvBuffer, long length, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Scatter_50(base.GetCppThis(), sendBuffer, recvBuffer, length, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Scatter_51(HandleRef pThis, HandleRef sendBuffer, HandleRef recvBuffer, int srcProcessId);

		public int Scatter(vtkDataArray sendBuffer, vtkDataArray recvBuffer, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_Scatter_51(base.GetCppThis(), (sendBuffer == null) ? default(HandleRef) : sendBuffer.GetCppThis(), (recvBuffer == null) ? default(HandleRef) : recvBuffer.GetCppThis(), srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_ScatterV_52(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

		public int ScatterV(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ScatterV_52(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_ScatterV_53(HandleRef pThis, string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId);

		public int ScatterV(string sendBuffer, string recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ScatterV_53(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_ScatterVVoidArray_54(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId);

		public virtual int ScatterVVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, IntPtr sendLengths, IntPtr offsets, long recvLength, int type, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ScatterVVoidArray_54(base.GetCppThis(), sendBuffer, recvBuffer, sendLengths, offsets, recvLength, type, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_ScatterVoidArray_55(HandleRef pThis, IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId);

		public virtual int ScatterVoidArray(IntPtr sendBuffer, IntPtr recvBuffer, long length, int type, int srcProcessId)
		{
			return vtkCommunicator.vtkCommunicator_ScatterVoidArray_55(base.GetCppThis(), sendBuffer, recvBuffer, length, type, srcProcessId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Send_56(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

		public int Send(vtkDataObject data, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Send_56(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Send_57(HandleRef pThis, HandleRef data, int remoteHandle, int tag);

		public int Send(vtkDataArray data, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Send_57(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Send_58(HandleRef pThis, IntPtr data, long length, int remoteHandle, int tag);

		public int Send(IntPtr data, long length, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Send_58(base.GetCppThis(), data, length, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_Send_59(HandleRef pThis, string data, long length, int remoteHandle, int tag);

		public int Send(string data, long length, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_Send_59(base.GetCppThis(), data, length, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_SendVoidArray_60(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		public virtual int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkCommunicator.vtkCommunicator_SendVoidArray_60(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCommunicator_SetNumberOfProcesses_61(HandleRef pThis, int num);

		public virtual void SetNumberOfProcesses(int num)
		{
			vtkCommunicator.vtkCommunicator_SetNumberOfProcesses_61(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCommunicator_SetUseCopy_62(int useCopy);

		public static void SetUseCopy(int useCopy)
		{
			vtkCommunicator.vtkCommunicator_SetUseCopy_62(useCopy);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCommunicator_UnMarshalDataObject_63(HandleRef buffer, HandleRef arg1);

		public static int UnMarshalDataObject(vtkCharArray buffer, vtkDataObject arg1)
		{
			return vtkCommunicator.vtkCommunicator_UnMarshalDataObject_63((buffer == null) ? default(HandleRef) : buffer.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}
	}
}
