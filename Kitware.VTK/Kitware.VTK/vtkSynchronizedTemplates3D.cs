using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSynchronizedTemplates3D : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedTemplates3D";

		public new static readonly string MRClassNameKey;

		static vtkSynchronizedTemplates3D()
		{
			vtkSynchronizedTemplates3D.MRClassNameKey = "class vtkSynchronizedTemplates3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizedTemplates3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedTemplates3D"));
		}

		public vtkSynchronizedTemplates3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedTemplates3D New()
		{
			vtkSynchronizedTemplates3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSynchronizedTemplates3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_ComputeGradientsOff_01(HandleRef pThis);

		public virtual void ComputeGradientsOff()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeGradientsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_ComputeGradientsOn_02(HandleRef pThis);

		public virtual void ComputeGradientsOn()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeGradientsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_ComputeNormalsOff_03(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_ComputeNormalsOn_04(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_ComputeScalarsOff_05(HandleRef pThis);

		public virtual void ComputeScalarsOff()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeScalarsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_ComputeScalarsOn_06(HandleRef pThis);

		public virtual void ComputeScalarsOn()
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ComputeScalarsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_GenerateValues_07(HandleRef pThis, int numContours, IntPtr range);

		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GenerateValues_07(base.GetCppThis(), numContours, range);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_GenerateValues_08(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GenerateValues_08(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates3D_GetArrayComponent_09(HandleRef pThis);

		public virtual int GetArrayComponent()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetArrayComponent_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates3D_GetComputeGradients_10(HandleRef pThis);

		public virtual int GetComputeGradients()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetComputeGradients_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates3D_GetComputeNormals_11(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetComputeNormals_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates3D_GetComputeScalars_12(HandleRef pThis);

		public virtual int GetComputeScalars()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetComputeScalars_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates3D_GetExecuteExtent_13(HandleRef pThis);

		public int[] GetExecuteExtent()
		{
			IntPtr intPtr = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetExecuteExtent_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkSynchronizedTemplates3D_GetInputMemoryLimit_14(HandleRef pThis);

		public uint GetInputMemoryLimit()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetInputMemoryLimit_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkSynchronizedTemplates3D_GetMTime_15(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetMTime_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates3D_GetNumberOfContours_16(HandleRef pThis);

		public int GetNumberOfContours()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetNumberOfContours_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkSynchronizedTemplates3D_GetValue_17(HandleRef pThis, int i);

		public double GetValue(int i)
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetValue_17(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates3D_GetValues_18(HandleRef pThis);

		public IntPtr GetValues()
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetValues_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_GetValues_19(HandleRef pThis, IntPtr contourValues);

		public void GetValues(IntPtr contourValues)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_GetValues_19(base.GetCppThis(), contourValues);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates3D_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSynchronizedTemplates3D_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSynchronizedTemplates3D NewInstance()
		{
			vtkSynchronizedTemplates3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedTemplates3D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedTemplates3D SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizedTemplates3D vtkSynchronizedTemplates3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedTemplates3D = (vtkSynchronizedTemplates3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedTemplates3D.Register(null);
				}
			}
			return vtkSynchronizedTemplates3D;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_SetArrayComponent_25(HandleRef pThis, int _arg);

		public virtual void SetArrayComponent(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetArrayComponent_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_SetComputeGradients_26(HandleRef pThis, int _arg);

		public virtual void SetComputeGradients(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetComputeGradients_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_SetComputeNormals_27(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetComputeNormals_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_SetComputeScalars_28(HandleRef pThis, int _arg);

		public virtual void SetComputeScalars(int _arg)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetComputeScalars_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_SetInputMemoryLimit_29(HandleRef pThis, uint limit);

		public void SetInputMemoryLimit(uint limit)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetInputMemoryLimit_29(base.GetCppThis(), limit);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_SetNumberOfContours_30(HandleRef pThis, int number);

		public void SetNumberOfContours(int number)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetNumberOfContours_30(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_SetValue_31(HandleRef pThis, int i, double value);

		public void SetValue(int i, double value)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_SetValue_31(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSynchronizedTemplates3D_ThreadedExecute_32(HandleRef pThis, HandleRef data, HandleRef inInfo, HandleRef outInfo, IntPtr exExt, HandleRef inScalars);

		public void ThreadedExecute(vtkImageData data, vtkInformation inInfo, vtkInformation outInfo, IntPtr exExt, vtkDataArray inScalars)
		{
			vtkSynchronizedTemplates3D.vtkSynchronizedTemplates3D_ThreadedExecute_32(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (inInfo == null) ? default(HandleRef) : inInfo.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), exExt, (inScalars == null) ? default(HandleRef) : inScalars.GetCppThis());
		}
	}
}
