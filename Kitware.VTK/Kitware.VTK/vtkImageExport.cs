using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageExport : vtkImageAlgorithm
	{
		public delegate IntPtr BufferPointerCallbackType(IntPtr arg0);

		public delegate IntPtr DataExtentCallbackType(IntPtr arg0);

		public delegate int NumberOfComponentsCallbackType(IntPtr arg0);

		public delegate IntPtr OriginCallbackType(IntPtr arg0);

		public delegate int PipelineModifiedCallbackType(IntPtr arg0);

		public delegate void PropagateUpdateExtentCallbackType(IntPtr arg0, IntPtr arg1);

		public delegate IntPtr ScalarTypeCallbackType(IntPtr arg0);

		public delegate IntPtr SpacingCallbackType(IntPtr arg0);

		public delegate void UpdateDataCallbackType(IntPtr arg0);

		public delegate void UpdateInformationCallbackType(IntPtr arg0);

		public delegate IntPtr WholeExtentCallbackType(IntPtr arg0);

		public new const string MRFullTypeName = "Kitware.VTK.vtkImageExport";

		public new static readonly string MRClassNameKey;

		static vtkImageExport()
		{
			vtkImageExport.MRClassNameKey = "class vtkImageExport";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageExport.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageExport"));
		}

		public vtkImageExport(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageExport New()
		{
			vtkImageExport result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageExport.vtkImageExport_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageExport() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageExport.vtkImageExport_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_Export_01(HandleRef pThis);

		public void Export()
		{
			vtkImageExport.vtkImageExport_Export_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_Export_02(HandleRef pThis, IntPtr arg0);

		public virtual void Export(IntPtr arg0)
		{
			vtkImageExport.vtkImageExport_Export_02(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.BufferPointerCallbackType vtkImageExport_GetBufferPointerCallback_03(HandleRef pThis);

		public vtkImageExport.BufferPointerCallbackType GetBufferPointerCallback()
		{
			return vtkImageExport.vtkImageExport_GetBufferPointerCallback_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetCallbackUserData_04(HandleRef pThis);

		public IntPtr GetCallbackUserData()
		{
			return vtkImageExport.vtkImageExport_GetCallbackUserData_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_GetDataDimensions_05(HandleRef pThis, IntPtr ptr);

		public void GetDataDimensions(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataDimensions_05(base.GetCppThis(), ptr);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetDataDimensions_06(HandleRef pThis);

		public int[] GetDataDimensions()
		{
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetDataDimensions_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetDataExtent_07(HandleRef pThis);

		public int[] GetDataExtent()
		{
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetDataExtent_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_GetDataExtent_08(HandleRef pThis, IntPtr ptr);

		public void GetDataExtent(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataExtent_08(base.GetCppThis(), ptr);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.DataExtentCallbackType vtkImageExport_GetDataExtentCallback_09(HandleRef pThis);

		public vtkImageExport.DataExtentCallbackType GetDataExtentCallback()
		{
			return vtkImageExport.vtkImageExport_GetDataExtentCallback_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExport_GetDataMemorySize_10(HandleRef pThis);

		public int GetDataMemorySize()
		{
			return vtkImageExport.vtkImageExport_GetDataMemorySize_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExport_GetDataNumberOfScalarComponents_11(HandleRef pThis);

		public int GetDataNumberOfScalarComponents()
		{
			return vtkImageExport.vtkImageExport_GetDataNumberOfScalarComponents_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetDataOrigin_12(HandleRef pThis);

		public double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetDataOrigin_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_GetDataOrigin_13(HandleRef pThis, IntPtr ptr);

		public void GetDataOrigin(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataOrigin_13(base.GetCppThis(), ptr);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExport_GetDataScalarType_14(HandleRef pThis);

		public int GetDataScalarType()
		{
			return vtkImageExport.vtkImageExport_GetDataScalarType_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetDataScalarTypeAsString_15(HandleRef pThis);

		public string GetDataScalarTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImageExport.vtkImageExport_GetDataScalarTypeAsString_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetDataSpacing_16(HandleRef pThis);

		public double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetDataSpacing_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_GetDataSpacing_17(HandleRef pThis, IntPtr ptr);

		public void GetDataSpacing(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataSpacing_17(base.GetCppThis(), ptr);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetExportVoidPointer_18(HandleRef pThis);

		public IntPtr GetExportVoidPointer()
		{
			return vtkImageExport.vtkImageExport_GetExportVoidPointer_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExport_GetImageLowerLeft_19(HandleRef pThis);

		public virtual int GetImageLowerLeft()
		{
			return vtkImageExport.vtkImageExport_GetImageLowerLeft_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetInput_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetInput_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.NumberOfComponentsCallbackType vtkImageExport_GetNumberOfComponentsCallback_21(HandleRef pThis);

		public vtkImageExport.NumberOfComponentsCallbackType GetNumberOfComponentsCallback()
		{
			return vtkImageExport.vtkImageExport_GetNumberOfComponentsCallback_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.OriginCallbackType vtkImageExport_GetOriginCallback_22(HandleRef pThis);

		public vtkImageExport.OriginCallbackType GetOriginCallback()
		{
			return vtkImageExport.vtkImageExport_GetOriginCallback_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.NumberOfComponentsCallbackType vtkImageExport_GetPipelineModifiedCallback_23(HandleRef pThis);

		public vtkImageExport.NumberOfComponentsCallbackType GetPipelineModifiedCallback()
		{
			return vtkImageExport.vtkImageExport_GetPipelineModifiedCallback_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_GetPointerToData_24(HandleRef pThis);

		public IntPtr GetPointerToData()
		{
			return vtkImageExport.vtkImageExport_GetPointerToData_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.PropagateUpdateExtentCallbackType vtkImageExport_GetPropagateUpdateExtentCallback_25(HandleRef pThis);

		public vtkImageExport.PropagateUpdateExtentCallbackType GetPropagateUpdateExtentCallback()
		{
			return vtkImageExport.vtkImageExport_GetPropagateUpdateExtentCallback_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.ScalarTypeCallbackType vtkImageExport_GetScalarTypeCallback_26(HandleRef pThis);

		public vtkImageExport.ScalarTypeCallbackType GetScalarTypeCallback()
		{
			return vtkImageExport.vtkImageExport_GetScalarTypeCallback_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.OriginCallbackType vtkImageExport_GetSpacingCallback_27(HandleRef pThis);

		public vtkImageExport.OriginCallbackType GetSpacingCallback()
		{
			return vtkImageExport.vtkImageExport_GetSpacingCallback_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.UpdateDataCallbackType vtkImageExport_GetUpdateDataCallback_28(HandleRef pThis);

		public vtkImageExport.UpdateDataCallbackType GetUpdateDataCallback()
		{
			return vtkImageExport.vtkImageExport_GetUpdateDataCallback_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.UpdateDataCallbackType vtkImageExport_GetUpdateInformationCallback_29(HandleRef pThis);

		public vtkImageExport.UpdateDataCallbackType GetUpdateInformationCallback()
		{
			return vtkImageExport.vtkImageExport_GetUpdateInformationCallback_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern vtkImageExport.DataExtentCallbackType vtkImageExport_GetWholeExtentCallback_30(HandleRef pThis);

		public vtkImageExport.DataExtentCallbackType GetWholeExtentCallback()
		{
			return vtkImageExport.vtkImageExport_GetWholeExtentCallback_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_ImageLowerLeftOff_31(HandleRef pThis);

		public virtual void ImageLowerLeftOff()
		{
			vtkImageExport.vtkImageExport_ImageLowerLeftOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_ImageLowerLeftOn_32(HandleRef pThis);

		public virtual void ImageLowerLeftOn()
		{
			vtkImageExport.vtkImageExport_ImageLowerLeftOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExport_IsA_33(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageExport.vtkImageExport_IsA_33(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExport_IsTypeOf_34(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageExport.vtkImageExport_IsTypeOf_34(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageExport NewInstance()
		{
			vtkImageExport result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageExport.vtkImageExport_NewInstance_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExport_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageExport SafeDownCast(vtkObjectBase o)
		{
			vtkImageExport vtkImageExport = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageExport.vtkImageExport_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageExport = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageExport.Register(null);
				}
			}
			return vtkImageExport;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_SetExportVoidPointer_38(HandleRef pThis, IntPtr arg0);

		public void SetExportVoidPointer(IntPtr arg0)
		{
			vtkImageExport.vtkImageExport_SetExportVoidPointer_38(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExport_SetImageLowerLeft_39(HandleRef pThis, int _arg);

		public virtual void SetImageLowerLeft(int _arg)
		{
			vtkImageExport.vtkImageExport_SetImageLowerLeft_39(base.GetCppThis(), _arg);
		}
	}
}
