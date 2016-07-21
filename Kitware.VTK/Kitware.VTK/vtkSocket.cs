using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSocket : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSocket";

		public new static readonly string MRClassNameKey;

		static vtkSocket()
		{
			vtkSocket.MRClassNameKey = "class vtkSocket";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSocket.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocket"));
		}

		public vtkSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkSocket_CloseSocket_01(HandleRef pThis);

		public void CloseSocket()
		{
			vtkSocket.vtkSocket_CloseSocket_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocket_GetConnected_02(HandleRef pThis);

		public int GetConnected()
		{
			return vtkSocket.vtkSocket_GetConnected_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocket_GetSocketDescriptor_03(HandleRef pThis);

		public virtual int GetSocketDescriptor()
		{
			return vtkSocket.vtkSocket_GetSocketDescriptor_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocket_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSocket.vtkSocket_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocket_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSocket.vtkSocket_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSocket_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSocket NewInstance()
		{
			vtkSocket result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocket.vtkSocket_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocket_Receive_07(HandleRef pThis, IntPtr data, int length, int readFully);

		public int Receive(IntPtr data, int length, int readFully)
		{
			return vtkSocket.vtkSocket_Receive_07(base.GetCppThis(), data, length, readFully);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkSocket_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSocket SafeDownCast(vtkObjectBase o)
		{
			vtkSocket vtkSocket = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSocket.vtkSocket_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocket = (vtkSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocket.Register(null);
				}
			}
			return vtkSocket;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocket_SelectSockets_09(IntPtr sockets_to_select, int size, uint msec, IntPtr selected_index);

		public static int SelectSockets(IntPtr sockets_to_select, int size, uint msec, IntPtr selected_index)
		{
			return vtkSocket.vtkSocket_SelectSockets_09(sockets_to_select, size, msec, selected_index);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkSocket_Send_10(HandleRef pThis, IntPtr data, int length);

		public int Send(IntPtr data, int length)
		{
			return vtkSocket.vtkSocket_Send_10(base.GetCppThis(), data, length);
		}
	}
}
