using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClientSocket : vtkSocket
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClientSocket";

		public new static readonly string MRClassNameKey;

		static vtkClientSocket()
		{
			vtkClientSocket.MRClassNameKey = "class vtkClientSocket";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClientSocket.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClientSocket"));
		}

		public vtkClientSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkClientSocket_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClientSocket New()
		{
			vtkClientSocket result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientSocket.vtkClientSocket_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClientSocket() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClientSocket.vtkClientSocket_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkClientSocket_ConnectToServer_01(HandleRef pThis, string hostname, int port);

		public int ConnectToServer(string hostname, int port)
		{
			return vtkClientSocket.vtkClientSocket_ConnectToServer_01(base.GetCppThis(), hostname, port);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkClientSocket_GetConnectingSide_02(HandleRef pThis);

		public virtual bool GetConnectingSide()
		{
			return vtkClientSocket.vtkClientSocket_GetConnectingSide_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkClientSocket_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClientSocket.vtkClientSocket_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkClientSocket_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClientSocket.vtkClientSocket_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkClientSocket_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClientSocket NewInstance()
		{
			vtkClientSocket result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientSocket.vtkClientSocket_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkClientSocket_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClientSocket SafeDownCast(vtkObjectBase o)
		{
			vtkClientSocket vtkClientSocket = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClientSocket.vtkClientSocket_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
