using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMarchingCubes : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMarchingCubes";

		public new static readonly string MRClassNameKey;

		static vtkImageMarchingCubes()
		{
			vtkImageMarchingCubes.MRClassNameKey = "class vtkImageMarchingCubes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMarchingCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMarchingCubes"));
		}

		public vtkImageMarchingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMarchingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMarchingCubes New()
		{
			vtkImageMarchingCubes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMarchingCubes.vtkImageMarchingCubes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMarchingCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMarchingCubes.vtkImageMarchingCubes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_AddLocatorPoint_01(HandleRef pThis, int cellX, int cellY, int edge, int ptId);

		public void AddLocatorPoint(int cellX, int cellY, int edge, int ptId)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_AddLocatorPoint_01(base.GetCppThis(), cellX, cellY, edge, ptId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_ComputeGradientsOff_02(HandleRef pThis);

		public virtual void ComputeGradientsOff()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeGradientsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_ComputeGradientsOn_03(HandleRef pThis);

		public virtual void ComputeGradientsOn()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeGradientsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_ComputeNormalsOff_04(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeNormalsOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_ComputeNormalsOn_05(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeNormalsOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_ComputeScalarsOff_06(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeScalarsOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_ComputeScalarsOn_07(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_ComputeScalarsOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageMarchingCubes_GetComputeGradients_10(HandleRef pThis);

		public virtual int GetComputeGradients()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetComputeGradients_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageMarchingCubes_GetComputeNormals_11(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetComputeNormals_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageMarchingCubes_GetComputeScalars_12(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetComputeScalars_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageMarchingCubes_GetInputMemoryLimit_13(HandleRef pThis);

		public virtual int GetInputMemoryLimit()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetInputMemoryLimit_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageMarchingCubes_GetLocatorPoint_14(HandleRef pThis, int cellX, int cellY, int edge);

		public int GetLocatorPoint(int cellX, int cellY, int edge)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetLocatorPoint_14(base.GetCppThis(), cellX, cellY, edge);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkImageMarchingCubes_GetMTime_15(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetMTime_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageMarchingCubes_GetNumberOfContours_16(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetNumberOfContours_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkImageMarchingCubes_GetValue_17(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetValue_17(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMarchingCubes_GetValues_18(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_GetValues_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_GetValues_19(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_GetValues_19(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_IncrementLocatorZ_20(HandleRef pThis);

		public void IncrementLocatorZ()
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_IncrementLocatorZ_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageMarchingCubes_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkImageMarchingCubes_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMarchingCubes.vtkImageMarchingCubes_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMarchingCubes_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMarchingCubes NewInstance()
		{
			vtkImageMarchingCubes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMarchingCubes.vtkImageMarchingCubes_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMarchingCubes_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMarchingCubes SafeDownCast(vtkObjectBase o)
		{
			vtkImageMarchingCubes vtkImageMarchingCubes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMarchingCubes.vtkImageMarchingCubes_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMarchingCubes = (vtkImageMarchingCubes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMarchingCubes.Register(null);
				}
			}
			return vtkImageMarchingCubes;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_SetComputeGradients_26(HandleRef pThis, int _arg);

		public virtual void SetComputeGradients(int _arg)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetComputeGradients_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_SetComputeNormals_27(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetComputeNormals_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_SetComputeScalars_28(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetComputeScalars_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_SetInputMemoryLimit_29(HandleRef pThis, int _arg);

		public virtual void SetInputMemoryLimit(int _arg)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetInputMemoryLimit_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_SetNumberOfContours_30(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetNumberOfContours_30(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkImageMarchingCubes_SetValue_31(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkImageMarchingCubes.vtkImageMarchingCubes_SetValue_31(base.GetCppThis(), i, value);
		}
	}
}
