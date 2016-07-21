using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSelectEnclosedPoints : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSelectEnclosedPoints";

		public new static readonly string MRClassNameKey;

		static vtkSelectEnclosedPoints()
		{
			vtkSelectEnclosedPoints.MRClassNameKey = "class vtkSelectEnclosedPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSelectEnclosedPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSelectEnclosedPoints"));
		}

		public vtkSelectEnclosedPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectEnclosedPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelectEnclosedPoints New()
		{
			vtkSelectEnclosedPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSelectEnclosedPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_CheckSurfaceOff_01(HandleRef pThis);

		public virtual void CheckSurfaceOff()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_CheckSurfaceOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_CheckSurfaceOn_02(HandleRef pThis);

		public virtual void CheckSurfaceOn()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_CheckSurfaceOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_Complete_03(HandleRef pThis);

		public void Complete()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_Complete_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectEnclosedPoints_GetCheckSurface_04(HandleRef pThis);

		public virtual int GetCheckSurface()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetCheckSurface_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectEnclosedPoints_GetInsideOut_05(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetInsideOut_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectEnclosedPoints_GetSurface_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSurface()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetSurface_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSelectEnclosedPoints_GetSurface_07(HandleRef pThis, HandleRef sourceInfo, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetSurface(vtkInformationVector sourceInfo)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetSurface_07(base.GetCppThis(), (sourceInfo == null) ? default(HandleRef) : sourceInfo.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkSelectEnclosedPoints_GetTolerance_08(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetTolerance_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSelectEnclosedPoints_GetToleranceMaxValue_09(HandleRef pThis);

		public virtual double GetToleranceMaxValue()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetToleranceMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSelectEnclosedPoints_GetToleranceMinValue_10(HandleRef pThis);

		public virtual double GetToleranceMinValue()
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_GetToleranceMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_Initialize_11(HandleRef pThis, HandleRef surface);

		public void Initialize(vtkPolyData surface)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_Initialize_11(base.GetCppThis(), (surface == null) ? default(HandleRef) : surface.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_InsideOutOff_12(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_InsideOutOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_InsideOutOn_13(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_InsideOutOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectEnclosedPoints_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectEnclosedPoints_IsInside_15(HandleRef pThis, long inputPtId);

		public int IsInside(long inputPtId)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsInside_15(base.GetCppThis(), inputPtId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectEnclosedPoints_IsInsideSurface_16(HandleRef pThis, double x, double y, double z);

		public int IsInsideSurface(double x, double y, double z)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsInsideSurface_16(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectEnclosedPoints_IsInsideSurface_17(HandleRef pThis, IntPtr x);

		public int IsInsideSurface(IntPtr x)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsInsideSurface_17(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSelectEnclosedPoints_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectEnclosedPoints_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSelectEnclosedPoints NewInstance()
		{
			vtkSelectEnclosedPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSelectEnclosedPoints_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSelectEnclosedPoints SafeDownCast(vtkObjectBase o)
		{
			vtkSelectEnclosedPoints vtkSelectEnclosedPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSelectEnclosedPoints = (vtkSelectEnclosedPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSelectEnclosedPoints.Register(null);
				}
			}
			return vtkSelectEnclosedPoints;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_SetCheckSurface_22(HandleRef pThis, int _arg);

		public virtual void SetCheckSurface(int _arg)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetCheckSurface_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_SetInsideOut_23(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetInsideOut_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_SetSurface_24(HandleRef pThis, HandleRef pd);

		public void SetSurface(vtkPolyData pd)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetSurface_24(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_SetSurfaceConnection_25(HandleRef pThis, HandleRef algOutput);

		public void SetSurfaceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetSurfaceConnection_25(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSelectEnclosedPoints_SetTolerance_26(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkSelectEnclosedPoints.vtkSelectEnclosedPoints_SetTolerance_26(base.GetCppThis(), _arg);
		}
	}
}
