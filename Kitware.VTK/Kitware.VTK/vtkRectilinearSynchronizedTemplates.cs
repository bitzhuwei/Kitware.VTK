using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRectilinearSynchronizedTemplates : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearSynchronizedTemplates";

		public new static readonly string MRClassNameKey;

		static vtkRectilinearSynchronizedTemplates()
		{
			vtkRectilinearSynchronizedTemplates.MRClassNameKey = "class vtkRectilinearSynchronizedTemplates";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearSynchronizedTemplates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearSynchronizedTemplates"));
		}

		public vtkRectilinearSynchronizedTemplates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearSynchronizedTemplates New()
		{
			vtkRectilinearSynchronizedTemplates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRectilinearSynchronizedTemplates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeGradientsOff_01(HandleRef pThis);

		public virtual void ComputeGradientsOff()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeGradientsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeGradientsOn_02(HandleRef pThis);

		public virtual void ComputeGradientsOn()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeGradientsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeScalarsOff_05(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeScalarsOn_06(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_ComputeSpacing_07(HandleRef pThis, HandleRef data, int i, int j, int k, IntPtr extent, IntPtr spacing);

		public void ComputeSpacing(vtkRectilinearGrid data, int i, int j, int k, IntPtr extent, IntPtr spacing)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_ComputeSpacing_07(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), i, j, k, extent, spacing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_GenerateValues_08(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GenerateValues_08(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_GenerateValues_09(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GenerateValues_09(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetArrayComponent_10(HandleRef pThis);

		public virtual int GetArrayComponent()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetArrayComponent_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeGradients_11(HandleRef pThis);

		public virtual int GetComputeGradients()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetComputeGradients_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeNormals_12(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetComputeNormals_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetComputeScalars_13(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetComputeScalars_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_GetExecuteExtent_14(HandleRef pThis);

		public IntPtr GetExecuteExtent()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetExecuteExtent_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkRectilinearSynchronizedTemplates_GetMTime_15(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetMTime_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearSynchronizedTemplates_GetNumberOfContours_16(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetNumberOfContours_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRectilinearSynchronizedTemplates_GetValue_17(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetValue_17(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_GetValues_18(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetValues_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_GetValues_19(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_GetValues_19(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearSynchronizedTemplates_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRectilinearSynchronizedTemplates_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearSynchronizedTemplates NewInstance()
		{
			vtkRectilinearSynchronizedTemplates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearSynchronizedTemplates_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearSynchronizedTemplates SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearSynchronizedTemplates vtkRectilinearSynchronizedTemplates = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearSynchronizedTemplates = (vtkRectilinearSynchronizedTemplates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearSynchronizedTemplates.Register(null);
				}
			}
			return vtkRectilinearSynchronizedTemplates;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetArrayComponent_25(HandleRef pThis, int _arg);

		public virtual void SetArrayComponent(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetArrayComponent_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeGradients_26(HandleRef pThis, int _arg);

		public virtual void SetComputeGradients(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetComputeGradients_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeNormals_27(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetComputeNormals_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetComputeScalars_28(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetComputeScalars_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetNumberOfContours_29(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetNumberOfContours_29(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRectilinearSynchronizedTemplates_SetValue_30(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkRectilinearSynchronizedTemplates.vtkRectilinearSynchronizedTemplates_SetValue_30(base.GetCppThis(), i, value);
		}
	}
}
