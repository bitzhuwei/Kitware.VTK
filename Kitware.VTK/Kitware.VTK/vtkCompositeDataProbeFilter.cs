using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositeDataProbeFilter : vtkProbeFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataProbeFilter";

		public new static readonly string MRClassNameKey;

		static vtkCompositeDataProbeFilter()
		{
			vtkCompositeDataProbeFilter.MRClassNameKey = "class vtkCompositeDataProbeFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataProbeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataProbeFilter"));
		}

		public vtkCompositeDataProbeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataProbeFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataProbeFilter New()
		{
			vtkCompositeDataProbeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositeDataProbeFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkCompositeDataProbeFilter_GetPassPartialArrays_01(HandleRef pThis);

		public virtual bool GetPassPartialArrays()
		{
			return vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_GetPassPartialArrays_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCompositeDataProbeFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCompositeDataProbeFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataProbeFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositeDataProbeFilter NewInstance()
		{
			vtkCompositeDataProbeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCompositeDataProbeFilter_PassPartialArraysOff_06(HandleRef pThis);

		public virtual void PassPartialArraysOff()
		{
			vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_PassPartialArraysOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCompositeDataProbeFilter_PassPartialArraysOn_07(HandleRef pThis);

		public virtual void PassPartialArraysOn()
		{
			vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_PassPartialArraysOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataProbeFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataProbeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataProbeFilter vtkCompositeDataProbeFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataProbeFilter = (vtkCompositeDataProbeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataProbeFilter.Register(null);
				}
			}
			return vtkCompositeDataProbeFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCompositeDataProbeFilter_SetPassPartialArrays_09(HandleRef pThis, byte _arg);

		public virtual void SetPassPartialArrays(bool _arg)
		{
			vtkCompositeDataProbeFilter.vtkCompositeDataProbeFilter_SetPassPartialArrays_09(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
