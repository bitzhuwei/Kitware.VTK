using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPHardwareSelector : vtkHardwareSelector
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPHardwareSelector";

		public new static readonly string MRClassNameKey;

		static vtkPHardwareSelector()
		{
			vtkPHardwareSelector.MRClassNameKey = "class vtkPHardwareSelector";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPHardwareSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPHardwareSelector"));
		}

		public vtkPHardwareSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPHardwareSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPHardwareSelector New()
		{
			vtkPHardwareSelector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPHardwareSelector.vtkPHardwareSelector_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPHardwareSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPHardwareSelector.vtkPHardwareSelector_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkPHardwareSelector_CaptureBuffers_01(HandleRef pThis);

		public override bool CaptureBuffers()
		{
			return vtkPHardwareSelector.vtkPHardwareSelector_CaptureBuffers_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkPHardwareSelector_GetProcessIsRoot_02(HandleRef pThis);

		public virtual bool GetProcessIsRoot()
		{
			return vtkPHardwareSelector.vtkPHardwareSelector_GetProcessIsRoot_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPHardwareSelector_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPHardwareSelector.vtkPHardwareSelector_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPHardwareSelector_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPHardwareSelector.vtkPHardwareSelector_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPHardwareSelector_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPHardwareSelector NewInstance()
		{
			vtkPHardwareSelector result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPHardwareSelector.vtkPHardwareSelector_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPHardwareSelector_ProcessIsRootOff_07(HandleRef pThis);

		public virtual void ProcessIsRootOff()
		{
			vtkPHardwareSelector.vtkPHardwareSelector_ProcessIsRootOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPHardwareSelector_ProcessIsRootOn_08(HandleRef pThis);

		public virtual void ProcessIsRootOn()
		{
			vtkPHardwareSelector.vtkPHardwareSelector_ProcessIsRootOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPHardwareSelector_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPHardwareSelector SafeDownCast(vtkObjectBase o)
		{
			vtkPHardwareSelector vtkPHardwareSelector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPHardwareSelector.vtkPHardwareSelector_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPHardwareSelector = (vtkPHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPHardwareSelector.Register(null);
				}
			}
			return vtkPHardwareSelector;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPHardwareSelector_SetProcessIsRoot_10(HandleRef pThis, byte _arg);

		public virtual void SetProcessIsRoot(bool _arg)
		{
			vtkPHardwareSelector.vtkPHardwareSelector_SetProcessIsRoot_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
