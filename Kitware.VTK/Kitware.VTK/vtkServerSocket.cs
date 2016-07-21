using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkServerSocket : vtkSocket
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkServerSocket";

		public new static readonly string MRClassNameKey;

		static vtkServerSocket()
		{
			vtkServerSocket.MRClassNameKey = "class vtkServerSocket";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkServerSocket.MRClassNameKey, Type.GetType("Kitware.VTK.vtkServerSocket"));
		}

		public vtkServerSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkServerSocket_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkServerSocket New()
		{
			vtkServerSocket result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkServerSocket.vtkServerSocket_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkServerSocket() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkServerSocket.vtkServerSocket_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkServerSocket_CreateServer_01(HandleRef pThis, int port);

		public int CreateServer(int port)
		{
			return vtkServerSocket.vtkServerSocket_CreateServer_01(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkServerSocket_GetServerPort_02(HandleRef pThis);

		public int GetServerPort()
		{
			return vtkServerSocket.vtkServerSocket_GetServerPort_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkServerSocket_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkServerSocket.vtkServerSocket_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkServerSocket_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkServerSocket.vtkServerSocket_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkServerSocket_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkServerSocket NewInstance()
		{
			vtkServerSocket result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkServerSocket.vtkServerSocket_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkServerSocket_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkServerSocket SafeDownCast(vtkObjectBase o)
		{
			vtkServerSocket vtkServerSocket = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkServerSocket.vtkServerSocket_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkServerSocket = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkServerSocket.Register(null);
				}
			}
			return vtkServerSocket;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkServerSocket_WaitForConnection_08(HandleRef pThis, uint msec, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkClientSocket WaitForConnection(uint msec)
		{
			vtkClientSocket vtkClientSocket = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkServerSocket.vtkServerSocket_WaitForConnection_08(base.GetCppThis(), msec, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	}
}
