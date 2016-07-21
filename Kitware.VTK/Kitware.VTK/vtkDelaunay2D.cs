using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDelaunay2D : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDelaunay2D";

		public new static readonly string MRClassNameKey;

		static vtkDelaunay2D()
		{
			vtkDelaunay2D.MRClassNameKey = "class vtkDelaunay2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDelaunay2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelaunay2D"));
		}

		public vtkDelaunay2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDelaunay2D New()
		{
			vtkDelaunay2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDelaunay2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDelaunay2D.vtkDelaunay2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_BoundingTriangulationOff_01(HandleRef pThis);

		public virtual void BoundingTriangulationOff()
		{
			vtkDelaunay2D.vtkDelaunay2D_BoundingTriangulationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_BoundingTriangulationOn_02(HandleRef pThis);

		public virtual void BoundingTriangulationOn()
		{
			vtkDelaunay2D.vtkDelaunay2D_BoundingTriangulationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetAlpha_03(HandleRef pThis);

		public virtual double GetAlpha()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetAlpha_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetAlphaMaxValue_04(HandleRef pThis);

		public virtual double GetAlphaMaxValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetAlphaMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetAlphaMinValue_05(HandleRef pThis);

		public virtual double GetAlphaMinValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetAlphaMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay2D_GetBoundingTriangulation_06(HandleRef pThis);

		public virtual int GetBoundingTriangulation()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetBoundingTriangulation_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetOffset_07(HandleRef pThis);

		public virtual double GetOffset()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetOffset_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetOffsetMaxValue_08(HandleRef pThis);

		public virtual double GetOffsetMaxValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetOffsetMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetOffsetMinValue_09(HandleRef pThis);

		public virtual double GetOffsetMinValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetOffsetMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay2D_GetProjectionPlaneMode_10(HandleRef pThis);

		public virtual int GetProjectionPlaneMode()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetProjectionPlaneMode_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay2D_GetProjectionPlaneModeMaxValue_11(HandleRef pThis);

		public virtual int GetProjectionPlaneModeMaxValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetProjectionPlaneModeMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay2D_GetProjectionPlaneModeMinValue_12(HandleRef pThis);

		public virtual int GetProjectionPlaneModeMinValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetProjectionPlaneModeMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay2D_GetSource_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSource()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_GetSource_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetTolerance_14(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetTolerance_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetToleranceMaxValue_15(HandleRef pThis);

		public virtual double GetToleranceMaxValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetToleranceMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay2D_GetToleranceMinValue_16(HandleRef pThis);

		public virtual double GetToleranceMinValue()
		{
			return vtkDelaunay2D.vtkDelaunay2D_GetToleranceMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay2D_GetTransform_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_GetTransform_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay2D_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDelaunay2D.vtkDelaunay2D_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay2D_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDelaunay2D.vtkDelaunay2D_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay2D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDelaunay2D NewInstance()
		{
			vtkDelaunay2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay2D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDelaunay2D SafeDownCast(vtkObjectBase o)
		{
			vtkDelaunay2D vtkDelaunay2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay2D.vtkDelaunay2D_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDelaunay2D = (vtkDelaunay2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDelaunay2D.Register(null);
				}
			}
			return vtkDelaunay2D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_SetAlpha_23(HandleRef pThis, double _arg);

		public virtual void SetAlpha(double _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetAlpha_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_SetBoundingTriangulation_24(HandleRef pThis, int _arg);

		public virtual void SetBoundingTriangulation(int _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetBoundingTriangulation_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_SetOffset_25(HandleRef pThis, double _arg);

		public virtual void SetOffset(double _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetOffset_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_SetProjectionPlaneMode_26(HandleRef pThis, int _arg);

		public virtual void SetProjectionPlaneMode(int _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetProjectionPlaneMode_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_SetSource_27(HandleRef pThis, HandleRef arg0);

		public void SetSource(vtkPolyData arg0)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetSource_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_SetSourceConnection_28(HandleRef pThis, HandleRef algOutput);

		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetSourceConnection_28(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_SetTolerance_29(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetTolerance_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay2D_SetTransform_30(HandleRef pThis, HandleRef arg0);

		public virtual void SetTransform(vtkAbstractTransform arg0)
		{
			vtkDelaunay2D.vtkDelaunay2D_SetTransform_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
