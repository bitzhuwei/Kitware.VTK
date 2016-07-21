using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGridSynchronizedTemplates3D : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGridSynchronizedTemplates3D";

		public new static readonly string MRClassNameKey;

		static vtkGridSynchronizedTemplates3D()
		{
			vtkGridSynchronizedTemplates3D.MRClassNameKey = "class vtkGridSynchronizedTemplates3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGridSynchronizedTemplates3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGridSynchronizedTemplates3D"));
		}

		public vtkGridSynchronizedTemplates3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGridSynchronizedTemplates3D New()
		{
			vtkGridSynchronizedTemplates3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGridSynchronizedTemplates3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeGradientsOff_01(HandleRef pThis);

		public virtual void ComputeGradientsOff()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeGradientsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeGradientsOn_02(HandleRef pThis);

		public virtual void ComputeGradientsOn()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeGradientsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeScalarsOff_05(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_ComputeScalarsOn_06(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_ComputeScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_GenerateValues_07(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GenerateValues_07(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_GenerateValues_08(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GenerateValues_08(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGridSynchronizedTemplates3D_GetComputeGradients_09(HandleRef pThis);

		public virtual int GetComputeGradients()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetComputeGradients_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGridSynchronizedTemplates3D_GetComputeNormals_10(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetComputeNormals_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGridSynchronizedTemplates3D_GetComputeScalars_11(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetComputeScalars_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_GetExecuteExtent_12(HandleRef pThis);

		public int[] GetExecuteExtent()
		{
			IntPtr intPtr = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetExecuteExtent_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkGridSynchronizedTemplates3D_GetMTime_13(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetMTime_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGridSynchronizedTemplates3D_GetNumberOfContours_14(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetNumberOfContours_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGridSynchronizedTemplates3D_GetValue_15(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetValue_15(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_GetValues_16(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetValues_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_GetValues_17(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_GetValues_17(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGridSynchronizedTemplates3D_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGridSynchronizedTemplates3D_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGridSynchronizedTemplates3D NewInstance()
		{
			vtkGridSynchronizedTemplates3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGridSynchronizedTemplates3D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGridSynchronizedTemplates3D SafeDownCast(vtkObjectBase o)
		{
			vtkGridSynchronizedTemplates3D vtkGridSynchronizedTemplates3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGridSynchronizedTemplates3D = (vtkGridSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGridSynchronizedTemplates3D.Register(null);
				}
			}
			return vtkGridSynchronizedTemplates3D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_SetComputeGradients_23(HandleRef pThis, int _arg);

		public virtual void SetComputeGradients(int _arg)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetComputeGradients_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_SetComputeNormals_24(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetComputeNormals_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_SetComputeScalars_25(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetComputeScalars_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_SetInputMemoryLimit_26(HandleRef pThis, int limit);

		public void SetInputMemoryLimit(int limit)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetInputMemoryLimit_26(base.GetCppThis(), limit);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_SetNumberOfContours_27(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetNumberOfContours_27(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGridSynchronizedTemplates3D_SetValue_28(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkGridSynchronizedTemplates3D.vtkGridSynchronizedTemplates3D_SetValue_28(base.GetCppThis(), i, value);
		}
	}
}
