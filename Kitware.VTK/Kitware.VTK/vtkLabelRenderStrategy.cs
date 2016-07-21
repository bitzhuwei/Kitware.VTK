using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkLabelRenderStrategy : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelRenderStrategy";

		public new static readonly string MRClassNameKey;

		static vtkLabelRenderStrategy()
		{
			vtkLabelRenderStrategy.MRClassNameKey = "class vtkLabelRenderStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelRenderStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelRenderStrategy"));
		}

		public vtkLabelRenderStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelRenderStrategy_EndFrame_01(HandleRef pThis);

		public virtual void EndFrame()
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_EndFrame_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelRenderStrategy_GetDefaultTextProperty_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetDefaultTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelRenderStrategy.vtkLabelRenderStrategy_GetDefaultTextProperty_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelRenderStrategy_GetRenderer_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelRenderStrategy.vtkLabelRenderStrategy_GetRenderer_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelRenderStrategy_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelRenderStrategy_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelRenderStrategy_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabelRenderStrategy NewInstance()
		{
			vtkLabelRenderStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelRenderStrategy.vtkLabelRenderStrategy_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelRenderStrategy_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef arg0);

		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_ReleaseGraphicsResources_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelRenderStrategy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelRenderStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkLabelRenderStrategy vtkLabelRenderStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelRenderStrategy.vtkLabelRenderStrategy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelRenderStrategy = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelRenderStrategy.Register(null);
				}
			}
			return vtkLabelRenderStrategy;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelRenderStrategy_SetDefaultTextProperty_09(HandleRef pThis, HandleRef tprop);

		public virtual void SetDefaultTextProperty(vtkTextProperty tprop)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_SetDefaultTextProperty_09(base.GetCppThis(), (tprop == null) ? default(HandleRef) : tprop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelRenderStrategy_SetRenderer_10(HandleRef pThis, HandleRef ren);

		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_SetRenderer_10(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelRenderStrategy_StartFrame_11(HandleRef pThis);

		public virtual void StartFrame()
		{
			vtkLabelRenderStrategy.vtkLabelRenderStrategy_StartFrame_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelRenderStrategy_SupportsBoundedSize_12(HandleRef pThis);

		public virtual bool SupportsBoundedSize()
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_SupportsBoundedSize_12(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelRenderStrategy_SupportsRotation_13(HandleRef pThis);

		public virtual bool SupportsRotation()
		{
			return vtkLabelRenderStrategy.vtkLabelRenderStrategy_SupportsRotation_13(base.GetCppThis()) != 0;
		}
	}
}
