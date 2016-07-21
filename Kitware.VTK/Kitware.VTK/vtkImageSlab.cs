using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageSlab : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSlab";

		public new static readonly string MRClassNameKey;

		static vtkImageSlab()
		{
			vtkImageSlab.MRClassNameKey = "class vtkImageSlab";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSlab.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSlab"));
		}

		public vtkImageSlab(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSlab_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSlab New()
		{
			vtkImageSlab result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSlab.vtkImageSlab_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageSlab() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageSlab.vtkImageSlab_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetMultiSliceOutput_01(HandleRef pThis);

		public virtual int GetMultiSliceOutput()
		{
			return vtkImageSlab.vtkImageSlab_GetMultiSliceOutput_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetOperation_02(HandleRef pThis);

		public virtual int GetOperation()
		{
			return vtkImageSlab.vtkImageSlab_GetOperation_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSlab_GetOperationAsString_03(HandleRef pThis);

		public string GetOperationAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImageSlab.vtkImageSlab_GetOperationAsString_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetOperationMaxValue_04(HandleRef pThis);

		public virtual int GetOperationMaxValue()
		{
			return vtkImageSlab.vtkImageSlab_GetOperationMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetOperationMinValue_05(HandleRef pThis);

		public virtual int GetOperationMinValue()
		{
			return vtkImageSlab.vtkImageSlab_GetOperationMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetOrientation_06(HandleRef pThis);

		public virtual int GetOrientation()
		{
			return vtkImageSlab.vtkImageSlab_GetOrientation_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetOrientationMaxValue_07(HandleRef pThis);

		public virtual int GetOrientationMaxValue()
		{
			return vtkImageSlab.vtkImageSlab_GetOrientationMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetOrientationMinValue_08(HandleRef pThis);

		public virtual int GetOrientationMinValue()
		{
			return vtkImageSlab.vtkImageSlab_GetOrientationMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetOutputScalarType_09(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkImageSlab.vtkImageSlab_GetOutputScalarType_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSlab_GetSliceRange_10(HandleRef pThis);

		public virtual int[] GetSliceRange()
		{
			IntPtr intPtr = vtkImageSlab.vtkImageSlab_GetSliceRange_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_GetSliceRange_11(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetSliceRange(ref int _arg1, ref int _arg2)
		{
			vtkImageSlab.vtkImageSlab_GetSliceRange_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_GetSliceRange_12(HandleRef pThis, IntPtr _arg);

		public virtual void GetSliceRange(IntPtr _arg)
		{
			vtkImageSlab.vtkImageSlab_GetSliceRange_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_GetTrapezoidIntegration_13(HandleRef pThis);

		public virtual int GetTrapezoidIntegration()
		{
			return vtkImageSlab.vtkImageSlab_GetTrapezoidIntegration_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageSlab.vtkImageSlab_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSlab_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageSlab.vtkImageSlab_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_MultiSliceOutputOff_16(HandleRef pThis);

		public virtual void MultiSliceOutputOff()
		{
			vtkImageSlab.vtkImageSlab_MultiSliceOutputOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_MultiSliceOutputOn_17(HandleRef pThis);

		public virtual void MultiSliceOutputOn()
		{
			vtkImageSlab.vtkImageSlab_MultiSliceOutputOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSlab_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageSlab NewInstance()
		{
			vtkImageSlab result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSlab.vtkImageSlab_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSlab_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSlab SafeDownCast(vtkObjectBase o)
		{
			vtkImageSlab vtkImageSlab = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSlab.vtkImageSlab_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSlab = (vtkImageSlab)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSlab.Register(null);
				}
			}
			return vtkImageSlab;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetMultiSliceOutput_21(HandleRef pThis, int _arg);

		public virtual void SetMultiSliceOutput(int _arg)
		{
			vtkImageSlab.vtkImageSlab_SetMultiSliceOutput_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOperation_22(HandleRef pThis, int _arg);

		public virtual void SetOperation(int _arg)
		{
			vtkImageSlab.vtkImageSlab_SetOperation_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOperationToMax_23(HandleRef pThis);

		public void SetOperationToMax()
		{
			vtkImageSlab.vtkImageSlab_SetOperationToMax_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOperationToMean_24(HandleRef pThis);

		public void SetOperationToMean()
		{
			vtkImageSlab.vtkImageSlab_SetOperationToMean_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOperationToMin_25(HandleRef pThis);

		public void SetOperationToMin()
		{
			vtkImageSlab.vtkImageSlab_SetOperationToMin_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOperationToSum_26(HandleRef pThis);

		public void SetOperationToSum()
		{
			vtkImageSlab.vtkImageSlab_SetOperationToSum_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOrientation_27(HandleRef pThis, int _arg);

		public virtual void SetOrientation(int _arg)
		{
			vtkImageSlab.vtkImageSlab_SetOrientation_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOrientationToX_28(HandleRef pThis);

		public void SetOrientationToX()
		{
			vtkImageSlab.vtkImageSlab_SetOrientationToX_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOrientationToY_29(HandleRef pThis);

		public void SetOrientationToY()
		{
			vtkImageSlab.vtkImageSlab_SetOrientationToY_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOrientationToZ_30(HandleRef pThis);

		public void SetOrientationToZ()
		{
			vtkImageSlab.vtkImageSlab_SetOrientationToZ_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOutputScalarTypeToDouble_31(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkImageSlab.vtkImageSlab_SetOutputScalarTypeToDouble_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOutputScalarTypeToFloat_32(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkImageSlab.vtkImageSlab_SetOutputScalarTypeToFloat_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetOutputScalarTypeToInputScalarType_33(HandleRef pThis);

		public void SetOutputScalarTypeToInputScalarType()
		{
			vtkImageSlab.vtkImageSlab_SetOutputScalarTypeToInputScalarType_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetSliceRange_34(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetSliceRange(int _arg1, int _arg2)
		{
			vtkImageSlab.vtkImageSlab_SetSliceRange_34(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetSliceRange_35(HandleRef pThis, IntPtr _arg);

		public void SetSliceRange(IntPtr _arg)
		{
			vtkImageSlab.vtkImageSlab_SetSliceRange_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_SetTrapezoidIntegration_36(HandleRef pThis, int _arg);

		public virtual void SetTrapezoidIntegration(int _arg)
		{
			vtkImageSlab.vtkImageSlab_SetTrapezoidIntegration_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_TrapezoidIntegrationOff_37(HandleRef pThis);

		public virtual void TrapezoidIntegrationOff()
		{
			vtkImageSlab.vtkImageSlab_TrapezoidIntegrationOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSlab_TrapezoidIntegrationOn_38(HandleRef pThis);

		public virtual void TrapezoidIntegrationOn()
		{
			vtkImageSlab.vtkImageSlab_TrapezoidIntegrationOn_38(base.GetCppThis());
		}
	}
}
