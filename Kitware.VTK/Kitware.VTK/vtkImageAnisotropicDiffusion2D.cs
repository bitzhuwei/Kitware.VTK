using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageAnisotropicDiffusion2D : vtkImageSpatialAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAnisotropicDiffusion2D";

		public new static readonly string MRClassNameKey;

		static vtkImageAnisotropicDiffusion2D()
		{
			vtkImageAnisotropicDiffusion2D.MRClassNameKey = "class vtkImageAnisotropicDiffusion2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAnisotropicDiffusion2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAnisotropicDiffusion2D"));
		}

		public vtkImageAnisotropicDiffusion2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAnisotropicDiffusion2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAnisotropicDiffusion2D New()
		{
			vtkImageAnisotropicDiffusion2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageAnisotropicDiffusion2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_CornersOff_01(HandleRef pThis);

		public virtual void CornersOff()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_CornersOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_CornersOn_02(HandleRef pThis);

		public virtual void CornersOn()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_CornersOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_EdgesOff_03(HandleRef pThis);

		public virtual void EdgesOff()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_EdgesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_EdgesOn_04(HandleRef pThis);

		public virtual void EdgesOn()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_EdgesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_FacesOff_05(HandleRef pThis);

		public virtual void FacesOff()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_FacesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_FacesOn_06(HandleRef pThis);

		public virtual void FacesOn()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_FacesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetCorners_07(HandleRef pThis);

		public virtual int GetCorners()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetCorners_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageAnisotropicDiffusion2D_GetDiffusionFactor_08(HandleRef pThis);

		public virtual double GetDiffusionFactor()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetDiffusionFactor_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageAnisotropicDiffusion2D_GetDiffusionThreshold_09(HandleRef pThis);

		public virtual double GetDiffusionThreshold()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetDiffusionThreshold_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetEdges_10(HandleRef pThis);

		public virtual int GetEdges()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetEdges_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetFaces_11(HandleRef pThis);

		public virtual int GetFaces()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetFaces_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetGradientMagnitudeThreshold_12(HandleRef pThis);

		public virtual int GetGradientMagnitudeThreshold()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetGradientMagnitudeThreshold_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion2D_GetNumberOfIterations_13(HandleRef pThis);

		public virtual int GetNumberOfIterations()
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GetNumberOfIterations_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOff_14(HandleRef pThis);

		public virtual void GradientMagnitudeThresholdOff()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOn_15(HandleRef pThis);

		public virtual void GradientMagnitudeThresholdOn()
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_GradientMagnitudeThresholdOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion2D_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion2D_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAnisotropicDiffusion2D_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageAnisotropicDiffusion2D NewInstance()
		{
			vtkImageAnisotropicDiffusion2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAnisotropicDiffusion2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAnisotropicDiffusion2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageAnisotropicDiffusion2D vtkImageAnisotropicDiffusion2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAnisotropicDiffusion2D = (vtkImageAnisotropicDiffusion2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAnisotropicDiffusion2D.Register(null);
				}
			}
			return vtkImageAnisotropicDiffusion2D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetCorners_21(HandleRef pThis, int _arg);

		public virtual void SetCorners(int _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetCorners_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetDiffusionFactor_22(HandleRef pThis, double _arg);

		public virtual void SetDiffusionFactor(double _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetDiffusionFactor_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetDiffusionThreshold_23(HandleRef pThis, double _arg);

		public virtual void SetDiffusionThreshold(double _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetDiffusionThreshold_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetEdges_24(HandleRef pThis, int _arg);

		public virtual void SetEdges(int _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetEdges_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetFaces_25(HandleRef pThis, int _arg);

		public virtual void SetFaces(int _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetFaces_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetGradientMagnitudeThreshold_26(HandleRef pThis, int _arg);

		public virtual void SetGradientMagnitudeThreshold(int _arg)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetGradientMagnitudeThreshold_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion2D_SetNumberOfIterations_27(HandleRef pThis, int num);

		public void SetNumberOfIterations(int num)
		{
			vtkImageAnisotropicDiffusion2D.vtkImageAnisotropicDiffusion2D_SetNumberOfIterations_27(base.GetCppThis(), num);
		}
	}
}
