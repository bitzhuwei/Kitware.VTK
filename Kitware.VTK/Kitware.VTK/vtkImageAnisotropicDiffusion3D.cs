using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageAnisotropicDiffusion3D : vtkImageSpatialAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAnisotropicDiffusion3D";

		public new static readonly string MRClassNameKey;

		static vtkImageAnisotropicDiffusion3D()
		{
			vtkImageAnisotropicDiffusion3D.MRClassNameKey = "class vtkImageAnisotropicDiffusion3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAnisotropicDiffusion3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAnisotropicDiffusion3D"));
		}

		public vtkImageAnisotropicDiffusion3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAnisotropicDiffusion3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAnisotropicDiffusion3D New()
		{
			vtkImageAnisotropicDiffusion3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageAnisotropicDiffusion3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_CornersOff_01(HandleRef pThis);

		public virtual void CornersOff()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_CornersOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_CornersOn_02(HandleRef pThis);

		public virtual void CornersOn()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_CornersOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_EdgesOff_03(HandleRef pThis);

		public virtual void EdgesOff()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_EdgesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_EdgesOn_04(HandleRef pThis);

		public virtual void EdgesOn()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_EdgesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_FacesOff_05(HandleRef pThis);

		public virtual void FacesOff()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_FacesOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_FacesOn_06(HandleRef pThis);

		public virtual void FacesOn()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_FacesOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetCorners_07(HandleRef pThis);

		public virtual int GetCorners()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetCorners_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageAnisotropicDiffusion3D_GetDiffusionFactor_08(HandleRef pThis);

		public virtual double GetDiffusionFactor()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetDiffusionFactor_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageAnisotropicDiffusion3D_GetDiffusionThreshold_09(HandleRef pThis);

		public virtual double GetDiffusionThreshold()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetDiffusionThreshold_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetEdges_10(HandleRef pThis);

		public virtual int GetEdges()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetEdges_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetFaces_11(HandleRef pThis);

		public virtual int GetFaces()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetFaces_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetGradientMagnitudeThreshold_12(HandleRef pThis);

		public virtual int GetGradientMagnitudeThreshold()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetGradientMagnitudeThreshold_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion3D_GetNumberOfIterations_13(HandleRef pThis);

		public virtual int GetNumberOfIterations()
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GetNumberOfIterations_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOff_14(HandleRef pThis);

		public virtual void GradientMagnitudeThresholdOff()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOff_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOn_15(HandleRef pThis);

		public virtual void GradientMagnitudeThresholdOn()
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_GradientMagnitudeThresholdOn_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion3D_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageAnisotropicDiffusion3D_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAnisotropicDiffusion3D_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageAnisotropicDiffusion3D NewInstance()
		{
			vtkImageAnisotropicDiffusion3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageAnisotropicDiffusion3D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageAnisotropicDiffusion3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageAnisotropicDiffusion3D vtkImageAnisotropicDiffusion3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAnisotropicDiffusion3D = (vtkImageAnisotropicDiffusion3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAnisotropicDiffusion3D.Register(null);
				}
			}
			return vtkImageAnisotropicDiffusion3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetCorners_21(HandleRef pThis, int _arg);

		public virtual void SetCorners(int _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetCorners_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetDiffusionFactor_22(HandleRef pThis, double _arg);

		public virtual void SetDiffusionFactor(double _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetDiffusionFactor_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetDiffusionThreshold_23(HandleRef pThis, double _arg);

		public virtual void SetDiffusionThreshold(double _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetDiffusionThreshold_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetEdges_24(HandleRef pThis, int _arg);

		public virtual void SetEdges(int _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetEdges_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetFaces_25(HandleRef pThis, int _arg);

		public virtual void SetFaces(int _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetFaces_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetGradientMagnitudeThreshold_26(HandleRef pThis, int _arg);

		public virtual void SetGradientMagnitudeThreshold(int _arg)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetGradientMagnitudeThreshold_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageAnisotropicDiffusion3D_SetNumberOfIterations_27(HandleRef pThis, int num);

		public void SetNumberOfIterations(int num)
		{
			vtkImageAnisotropicDiffusion3D.vtkImageAnisotropicDiffusion3D_SetNumberOfIterations_27(base.GetCppThis(), num);
		}
	}
}
