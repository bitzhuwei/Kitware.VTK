using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoAdaptiveArcs : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoAdaptiveArcs";

		public new static readonly string MRClassNameKey;

		static vtkGeoAdaptiveArcs()
		{
			vtkGeoAdaptiveArcs.MRClassNameKey = "class vtkGeoAdaptiveArcs";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoAdaptiveArcs.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoAdaptiveArcs"));
		}

		public vtkGeoAdaptiveArcs(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAdaptiveArcs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoAdaptiveArcs New()
		{
			vtkGeoAdaptiveArcs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoAdaptiveArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoAdaptiveArcs() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoAdaptiveArcs_GetGlobeRadius_01(HandleRef pThis);

		public virtual double GetGlobeRadius()
		{
			return vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_GetGlobeRadius_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern uint vtkGeoAdaptiveArcs_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoAdaptiveArcs_GetMaximumPixelSeparation_03(HandleRef pThis);

		public virtual double GetMaximumPixelSeparation()
		{
			return vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_GetMaximumPixelSeparation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoAdaptiveArcs_GetMinimumPixelSeparation_04(HandleRef pThis);

		public virtual double GetMinimumPixelSeparation()
		{
			return vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_GetMinimumPixelSeparation_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAdaptiveArcs_GetRenderer_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_GetRenderer_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoAdaptiveArcs_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoAdaptiveArcs_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAdaptiveArcs_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoAdaptiveArcs NewInstance()
		{
			vtkGeoAdaptiveArcs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoAdaptiveArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoAdaptiveArcs_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoAdaptiveArcs SafeDownCast(vtkObjectBase o)
		{
			vtkGeoAdaptiveArcs vtkGeoAdaptiveArcs = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoAdaptiveArcs = (vtkGeoAdaptiveArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoAdaptiveArcs.Register(null);
				}
			}
			return vtkGeoAdaptiveArcs;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAdaptiveArcs_SetGlobeRadius_11(HandleRef pThis, double _arg);

		public virtual void SetGlobeRadius(double _arg)
		{
			vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_SetGlobeRadius_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAdaptiveArcs_SetMaximumPixelSeparation_12(HandleRef pThis, double _arg);

		public virtual void SetMaximumPixelSeparation(double _arg)
		{
			vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_SetMaximumPixelSeparation_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAdaptiveArcs_SetMinimumPixelSeparation_13(HandleRef pThis, double _arg);

		public virtual void SetMinimumPixelSeparation(double _arg)
		{
			vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_SetMinimumPixelSeparation_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoAdaptiveArcs_SetRenderer_14(HandleRef pThis, HandleRef ren);

		public virtual void SetRenderer(vtkRenderer ren)
		{
			vtkGeoAdaptiveArcs.vtkGeoAdaptiveArcs_SetRenderer_14(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}
	}
}
