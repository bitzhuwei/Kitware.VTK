using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLassoStencilSource : vtkImageStencilSource
	{
		public enum POLYGON_WrapperEnum
		{
			POLYGON,
			SPLINE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLassoStencilSource";

		public new static readonly string MRClassNameKey;

		static vtkLassoStencilSource()
		{
			vtkLassoStencilSource.MRClassNameKey = "class vtkLassoStencilSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLassoStencilSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLassoStencilSource"));
		}

		public vtkLassoStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkLassoStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLassoStencilSource New()
		{
			vtkLassoStencilSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLassoStencilSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLassoStencilSource.vtkLassoStencilSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern uint vtkLassoStencilSource_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkLassoStencilSource_GetPoints_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_GetPoints_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkLassoStencilSource_GetShape_03(HandleRef pThis);

		public virtual int GetShape()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetShape_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkLassoStencilSource_GetShapeAsString_04(HandleRef pThis);

		public virtual string GetShapeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkLassoStencilSource.vtkLassoStencilSource_GetShapeAsString_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkLassoStencilSource_GetShapeMaxValue_05(HandleRef pThis);

		public virtual int GetShapeMaxValue()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetShapeMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkLassoStencilSource_GetShapeMinValue_06(HandleRef pThis);

		public virtual int GetShapeMinValue()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetShapeMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkLassoStencilSource_GetSliceOrientation_07(HandleRef pThis);

		public virtual int GetSliceOrientation()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetSliceOrientation_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkLassoStencilSource_GetSliceOrientationMaxValue_08(HandleRef pThis);

		public virtual int GetSliceOrientationMaxValue()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetSliceOrientationMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkLassoStencilSource_GetSliceOrientationMinValue_09(HandleRef pThis);

		public virtual int GetSliceOrientationMinValue()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetSliceOrientationMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkLassoStencilSource_GetSlicePoints_10(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetSlicePoints(int i)
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_GetSlicePoints_10(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkLassoStencilSource_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkLassoStencilSource_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkLassoStencilSource_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLassoStencilSource NewInstance()
		{
			vtkLassoStencilSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkLassoStencilSource_RemoveAllSlicePoints_15(HandleRef pThis);

		public virtual void RemoveAllSlicePoints()
		{
			vtkLassoStencilSource.vtkLassoStencilSource_RemoveAllSlicePoints_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkLassoStencilSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLassoStencilSource SafeDownCast(vtkObjectBase o)
		{
			vtkLassoStencilSource vtkLassoStencilSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLassoStencilSource = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLassoStencilSource.Register(null);
				}
			}
			return vtkLassoStencilSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkLassoStencilSource_SetPoints_17(HandleRef pThis, HandleRef points);

		public virtual void SetPoints(vtkPoints points)
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetPoints_17(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkLassoStencilSource_SetShape_18(HandleRef pThis, int _arg);

		public virtual void SetShape(int _arg)
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetShape_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkLassoStencilSource_SetShapeToPolygon_19(HandleRef pThis);

		public void SetShapeToPolygon()
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetShapeToPolygon_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkLassoStencilSource_SetShapeToSpline_20(HandleRef pThis);

		public void SetShapeToSpline()
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetShapeToSpline_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkLassoStencilSource_SetSliceOrientation_21(HandleRef pThis, int _arg);

		public virtual void SetSliceOrientation(int _arg)
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetSliceOrientation_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkLassoStencilSource_SetSlicePoints_22(HandleRef pThis, int i, HandleRef points);

		public virtual void SetSlicePoints(int i, vtkPoints points)
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetSlicePoints_22(base.GetCppThis(), i, (points == null) ? default(HandleRef) : points.GetCppThis());
		}
	}
}
