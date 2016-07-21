using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThreadMessager : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkThreadMessager";

		public new static readonly string MRClassNameKey;

		static vtkThreadMessager()
		{
			vtkThreadMessager.MRClassNameKey = "class vtkThreadMessager";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreadMessager.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadMessager"));
		}

		public vtkThreadMessager(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadMessager_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThreadMessager New()
		{
			vtkThreadMessager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadMessager.vtkThreadMessager_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadMessager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkThreadMessager() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkThreadMessager.vtkThreadMessager_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkThreadMessager_DisableWaitForReceiver_01(HandleRef pThis);

		public void DisableWaitForReceiver()
		{
			vtkThreadMessager.vtkThreadMessager_DisableWaitForReceiver_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkThreadMessager_EnableWaitForReceiver_02(HandleRef pThis);

		public void EnableWaitForReceiver()
		{
			vtkThreadMessager.vtkThreadMessager_EnableWaitForReceiver_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkThreadMessager_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThreadMessager.vtkThreadMessager_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkThreadMessager_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThreadMessager.vtkThreadMessager_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadMessager_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThreadMessager NewInstance()
		{
			vtkThreadMessager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadMessager.vtkThreadMessager_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadMessager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkThreadMessager_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThreadMessager SafeDownCast(vtkObjectBase o)
		{
			vtkThreadMessager vtkThreadMessager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThreadMessager.vtkThreadMessager_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadMessager = (vtkThreadMessager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadMessager.Register(null);
				}
			}
			return vtkThreadMessager;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkThreadMessager_SendWakeMessage_08(HandleRef pThis);

		public void SendWakeMessage()
		{
			vtkThreadMessager.vtkThreadMessager_SendWakeMessage_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkThreadMessager_WaitForMessage_09(HandleRef pThis);

		public void WaitForMessage()
		{
			vtkThreadMessager.vtkThreadMessager_WaitForMessage_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkThreadMessager_WaitForReceiver_10(HandleRef pThis);

		public void WaitForReceiver()
		{
			vtkThreadMessager.vtkThreadMessager_WaitForReceiver_10(base.GetCppThis());
		}
	}
}
