using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFreeTypeLabelRenderStrategy : vtkLabelRenderStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFreeTypeLabelRenderStrategy";

		public new static readonly string MRClassNameKey;

		static vtkFreeTypeLabelRenderStrategy()
		{
			vtkFreeTypeLabelRenderStrategy.MRClassNameKey = "class vtkFreeTypeLabelRenderStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFreeTypeLabelRenderStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFreeTypeLabelRenderStrategy"));
		}

		public vtkFreeTypeLabelRenderStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFreeTypeLabelRenderStrategy New()
		{
			vtkFreeTypeLabelRenderStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFreeTypeLabelRenderStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFreeTypeLabelRenderStrategy_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFreeTypeLabelRenderStrategy_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFreeTypeLabelRenderStrategy NewInstance()
		{
			vtkFreeTypeLabelRenderStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFreeTypeLabelRenderStrategy_ReleaseGraphicsResources_05(HandleRef pThis, HandleRef window);

		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_ReleaseGraphicsResources_05(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFreeTypeLabelRenderStrategy_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFreeTypeLabelRenderStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkFreeTypeLabelRenderStrategy vtkFreeTypeLabelRenderStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFreeTypeLabelRenderStrategy = (vtkFreeTypeLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFreeTypeLabelRenderStrategy.Register(null);
				}
			}
			return vtkFreeTypeLabelRenderStrategy;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkFreeTypeLabelRenderStrategy_SupportsBoundedSize_07(HandleRef pThis);

		public override bool SupportsBoundedSize()
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_SupportsBoundedSize_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkFreeTypeLabelRenderStrategy_SupportsRotation_08(HandleRef pThis);

		public override bool SupportsRotation()
		{
			return vtkFreeTypeLabelRenderStrategy.vtkFreeTypeLabelRenderStrategy_SupportsRotation_08(base.GetCppThis()) != 0;
		}
	}
}
