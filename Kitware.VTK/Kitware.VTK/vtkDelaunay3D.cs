using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDelaunay3D : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDelaunay3D";

		public new static readonly string MRClassNameKey;

		static vtkDelaunay3D()
		{
			vtkDelaunay3D.MRClassNameKey = "class vtkDelaunay3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDelaunay3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelaunay3D"));
		}

		public vtkDelaunay3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDelaunay3D New()
		{
			vtkDelaunay3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDelaunay3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDelaunay3D.vtkDelaunay3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_BoundingTriangulationOff_01(HandleRef pThis);

		public virtual void BoundingTriangulationOff()
		{
			vtkDelaunay3D.vtkDelaunay3D_BoundingTriangulationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_BoundingTriangulationOn_02(HandleRef pThis);

		public virtual void BoundingTriangulationOn()
		{
			vtkDelaunay3D.vtkDelaunay3D_BoundingTriangulationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_CreateDefaultLocator_03(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkDelaunay3D.vtkDelaunay3D_CreateDefaultLocator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_EndPointInsertion_04(HandleRef pThis);

		public void EndPointInsertion()
		{
			vtkDelaunay3D.vtkDelaunay3D_EndPointInsertion_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetAlpha_05(HandleRef pThis);

		public virtual double GetAlpha()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlpha_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetAlphaMaxValue_06(HandleRef pThis);

		public virtual double GetAlphaMaxValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlphaMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetAlphaMinValue_07(HandleRef pThis);

		public virtual double GetAlphaMinValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetAlphaMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay3D_GetBoundingTriangulation_08(HandleRef pThis);

		public virtual int GetBoundingTriangulation()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetBoundingTriangulation_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay3D_GetLocator_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_GetLocator_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkDelaunay3D_GetMTime_10(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetMTime_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetOffset_11(HandleRef pThis);

		public virtual double GetOffset()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetOffset_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetOffsetMaxValue_12(HandleRef pThis);

		public virtual double GetOffsetMaxValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetOffsetMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetOffsetMinValue_13(HandleRef pThis);

		public virtual double GetOffsetMinValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetOffsetMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetTolerance_14(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetTolerance_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetToleranceMaxValue_15(HandleRef pThis);

		public virtual double GetToleranceMaxValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetToleranceMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDelaunay3D_GetToleranceMinValue_16(HandleRef pThis);

		public virtual double GetToleranceMinValue()
		{
			return vtkDelaunay3D.vtkDelaunay3D_GetToleranceMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay3D_InitPointInsertion_17(HandleRef pThis, IntPtr center, double length, long numPts, HandleRef pts, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid InitPointInsertion(IntPtr center, double length, long numPts, vtkPoints pts)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_InitPointInsertion_17(base.GetCppThis(), center, length, numPts, (pts == null) ? default(HandleRef) : pts.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_InsertPoint_18(HandleRef pThis, HandleRef Mesh, HandleRef points, long id, IntPtr x, HandleRef holeTetras);

		public void InsertPoint(vtkUnstructuredGrid Mesh, vtkPoints points, long id, IntPtr x, vtkIdList holeTetras)
		{
			vtkDelaunay3D.vtkDelaunay3D_InsertPoint_18(base.GetCppThis(), (Mesh == null) ? default(HandleRef) : Mesh.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), id, x, (holeTetras == null) ? default(HandleRef) : holeTetras.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay3D_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDelaunay3D.vtkDelaunay3D_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDelaunay3D_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDelaunay3D.vtkDelaunay3D_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay3D_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDelaunay3D NewInstance()
		{
			vtkDelaunay3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDelaunay3D_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDelaunay3D SafeDownCast(vtkObjectBase o)
		{
			vtkDelaunay3D vtkDelaunay3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelaunay3D.vtkDelaunay3D_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDelaunay3D = (vtkDelaunay3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDelaunay3D.Register(null);
				}
			}
			return vtkDelaunay3D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_SetAlpha_24(HandleRef pThis, double _arg);

		public virtual void SetAlpha(double _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetAlpha_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_SetBoundingTriangulation_25(HandleRef pThis, int _arg);

		public virtual void SetBoundingTriangulation(int _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetBoundingTriangulation_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_SetLocator_26(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetLocator_26(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_SetOffset_27(HandleRef pThis, double _arg);

		public virtual void SetOffset(double _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetOffset_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDelaunay3D_SetTolerance_28(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkDelaunay3D.vtkDelaunay3D_SetTolerance_28(base.GetCppThis(), _arg);
		}
	}
}
