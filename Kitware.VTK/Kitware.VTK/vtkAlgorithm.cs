using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAlgorithm : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkAlgorithm()
		{
			vtkAlgorithm.MRClassNameKey = "class vtkAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAlgorithm"));
		}

		public vtkAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAlgorithm New()
		{
			vtkAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAlgorithm.vtkAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_Register_48(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkAlgorithm.vtkAlgorithm_Register_48(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_UnRegister_67(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkAlgorithm.vtkAlgorithm_UnRegister_67(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_AbortExecuteOff_01(HandleRef pThis);

		public virtual void AbortExecuteOff()
		{
			vtkAlgorithm.vtkAlgorithm_AbortExecuteOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_AbortExecuteOn_02(HandleRef pThis);

		public virtual void AbortExecuteOn()
		{
			vtkAlgorithm.vtkAlgorithm_AbortExecuteOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_AddInputConnection_03(HandleRef pThis, int port, HandleRef input);

		public virtual void AddInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_AddInputConnection_03(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_AddInputConnection_04(HandleRef pThis, HandleRef input);

		public virtual void AddInputConnection(vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_AddInputConnection_04(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkAlgorithm_ComputePriority_05(HandleRef pThis);

		public virtual double ComputePriority()
		{
			return vtkAlgorithm.vtkAlgorithm_ComputePriority_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_ConvertTotalInputToPortConnection_06(HandleRef pThis, int ind, ref int port, ref int conn);

		public void ConvertTotalInputToPortConnection(int ind, ref int port, ref int conn)
		{
			vtkAlgorithm.vtkAlgorithm_ConvertTotalInputToPortConnection_06(base.GetCppThis(), ind, ref port, ref conn);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_GetAbortExecute_07(HandleRef pThis);

		public virtual int GetAbortExecute()
		{
			return vtkAlgorithm.vtkAlgorithm_GetAbortExecute_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkAlgorithm_GetErrorCode_08(HandleRef pThis);

		public virtual uint GetErrorCode()
		{
			return vtkAlgorithm.vtkAlgorithm_GetErrorCode_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetExecutive_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkExecutive GetExecutive()
		{
			vtkExecutive vtkExecutive = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetExecutive_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutive = (vtkExecutive)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutive.Register(null);
				}
			}
			return vtkExecutive;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetInformation_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInformation_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetInputArrayInformation_11(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetInputArrayInformation(int idx)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputArrayInformation_11(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetInputConnection_12(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAlgorithmOutput GetInputConnection(int port, int index)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputConnection_12(base.GetCppThis(), port, index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetInputDataObject_13(HandleRef pThis, int port, int connection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInputDataObject(int port, int connection)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputDataObject_13(base.GetCppThis(), port, connection, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetInputPortInformation_14(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetInputPortInformation(int port)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetInputPortInformation_14(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_GetNumberOfInputConnections_15(HandleRef pThis, int port);

		public int GetNumberOfInputConnections(int port)
		{
			return vtkAlgorithm.vtkAlgorithm_GetNumberOfInputConnections_15(base.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_GetNumberOfInputPorts_16(HandleRef pThis);

		public int GetNumberOfInputPorts()
		{
			return vtkAlgorithm.vtkAlgorithm_GetNumberOfInputPorts_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_GetNumberOfOutputPorts_17(HandleRef pThis);

		public int GetNumberOfOutputPorts()
		{
			return vtkAlgorithm.vtkAlgorithm_GetNumberOfOutputPorts_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetOutputDataObject_18(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetOutputDataObject(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputDataObject_18(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetOutputPort_19(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAlgorithmOutput GetOutputPort(int index)
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputPort_19(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetOutputPort_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAlgorithmOutput GetOutputPort()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputPort_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetOutputPortInformation_21(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkInformation GetOutputPortInformation(int port)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_GetOutputPortInformation_21(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkAlgorithm_GetProgress_22(HandleRef pThis);

		public virtual double GetProgress()
		{
			return vtkAlgorithm.vtkAlgorithm_GetProgress_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkAlgorithm_GetProgressMaxValue_23(HandleRef pThis);

		public virtual double GetProgressMaxValue()
		{
			return vtkAlgorithm.vtkAlgorithm_GetProgressMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkAlgorithm_GetProgressMinValue_24(HandleRef pThis);

		public virtual double GetProgressMinValue()
		{
			return vtkAlgorithm.vtkAlgorithm_GetProgressMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_GetProgressText_25(HandleRef pThis);

		public virtual string GetProgressText()
		{
			return Marshal.PtrToStringAnsi(vtkAlgorithm.vtkAlgorithm_GetProgressText_25(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_GetReleaseDataFlag_26(HandleRef pThis);

		public virtual int GetReleaseDataFlag()
		{
			return vtkAlgorithm.vtkAlgorithm_GetReleaseDataFlag_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_GetTotalNumberOfInputConnections_27(HandleRef pThis);

		public int GetTotalNumberOfInputConnections()
		{
			return vtkAlgorithm.vtkAlgorithm_GetTotalNumberOfInputConnections_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_HasExecutive_28(HandleRef pThis);

		public int HasExecutive()
		{
			return vtkAlgorithm.vtkAlgorithm_HasExecutive_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_29(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationInformationVectorKey INPUT_ARRAYS_TO_PROCESS()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_ARRAYS_TO_PROCESS_29(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_INPUT_CONNECTION_30(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey INPUT_CONNECTION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_CONNECTION_30(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_INPUT_IS_OPTIONAL_31(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey INPUT_IS_OPTIONAL()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_IS_OPTIONAL_31(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_INPUT_IS_REPEATABLE_32(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey INPUT_IS_REPEATABLE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_IS_REPEATABLE_32(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_INPUT_PORT_33(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey INPUT_PORT()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_PORT_33(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_34(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationStringVectorKey INPUT_REQUIRED_DATA_TYPE()
		{
			vtkInformationStringVectorKey vtkInformationStringVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_REQUIRED_DATA_TYPE_34(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringVectorKey = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringVectorKey.Register(null);
				}
			}
			return vtkInformationStringVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_INPUT_REQUIRED_FIELDS_35(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationInformationVectorKey INPUT_REQUIRED_FIELDS()
		{
			vtkInformationInformationVectorKey vtkInformationInformationVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_INPUT_REQUIRED_FIELDS_35(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationVectorKey = (vtkInformationInformationVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationVectorKey.Register(null);
				}
			}
			return vtkInformationInformationVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_IsA_36(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAlgorithm.vtkAlgorithm_IsA_36(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_IsTypeOf_37(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAlgorithm.vtkAlgorithm_IsTypeOf_37(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_ModifyRequest_38(HandleRef pThis, HandleRef request, int when);

		public virtual int ModifyRequest(vtkInformation request, int when)
		{
			return vtkAlgorithm.vtkAlgorithm_ModifyRequest_38(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), when);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAlgorithm NewInstance()
		{
			vtkAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_NewInstance_40(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_PRESERVES_ATTRIBUTES_41(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey PRESERVES_ATTRIBUTES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_PRESERVES_ATTRIBUTES_41(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_PRESERVES_BOUNDS_42(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey PRESERVES_BOUNDS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_PRESERVES_BOUNDS_42(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_PRESERVES_DATASET_43(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey PRESERVES_DATASET()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_PRESERVES_DATASET_43(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_PRESERVES_GEOMETRY_44(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey PRESERVES_GEOMETRY()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_PRESERVES_GEOMETRY_44(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_PRESERVES_RANGES_45(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey PRESERVES_RANGES()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_PRESERVES_RANGES_45(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_PRESERVES_TOPOLOGY_46(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey PRESERVES_TOPOLOGY()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_PRESERVES_TOPOLOGY_46(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_ProcessRequest_47(HandleRef pThis, HandleRef request, HandleRef inInfo, HandleRef outInfo);

		public int ProcessRequest(vtkInformation request, vtkCollection inInfo, vtkInformationVector outInfo)
		{
			return vtkAlgorithm.vtkAlgorithm_ProcessRequest_47(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (inInfo == null) ? default(HandleRef) : inInfo.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_ReleaseDataFlagOff_49(HandleRef pThis);

		public void ReleaseDataFlagOff()
		{
			vtkAlgorithm.vtkAlgorithm_ReleaseDataFlagOff_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_ReleaseDataFlagOn_50(HandleRef pThis);

		public void ReleaseDataFlagOn()
		{
			vtkAlgorithm.vtkAlgorithm_ReleaseDataFlagOn_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_RemoveAllInputs_51(HandleRef pThis);

		public void RemoveAllInputs()
		{
			vtkAlgorithm.vtkAlgorithm_RemoveAllInputs_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_RemoveInputConnection_52(HandleRef pThis, int port, HandleRef input);

		public virtual void RemoveInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_RemoveInputConnection_52(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAlgorithm_SafeDownCast_53(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkAlgorithm vtkAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAlgorithm.vtkAlgorithm_SafeDownCast_53((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithm = (vtkAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithm.Register(null);
				}
			}
			return vtkAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetAbortExecute_54(HandleRef pThis, int _arg);

		public virtual void SetAbortExecute(int _arg)
		{
			vtkAlgorithm.vtkAlgorithm_SetAbortExecute_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetDefaultExecutivePrototype_55(HandleRef proto);

		public static void SetDefaultExecutivePrototype(vtkExecutive proto)
		{
			vtkAlgorithm.vtkAlgorithm_SetDefaultExecutivePrototype_55((proto == null) ? default(HandleRef) : proto.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetExecutive_56(HandleRef pThis, HandleRef executive);

		public virtual void SetExecutive(vtkExecutive executive)
		{
			vtkAlgorithm.vtkAlgorithm_SetExecutive_56(base.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetInformation_57(HandleRef pThis, HandleRef arg0);

		public virtual void SetInformation(vtkInformation arg0)
		{
			vtkAlgorithm.vtkAlgorithm_SetInformation_57(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetInputArrayToProcess_58(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, string name);

		public virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, string name)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputArrayToProcess_58(base.GetCppThis(), idx, port, connection, fieldAssociation, name);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetInputArrayToProcess_59(HandleRef pThis, int idx, int port, int connection, int fieldAssociation, int fieldAttributeType);

		public virtual void SetInputArrayToProcess(int idx, int port, int connection, int fieldAssociation, int fieldAttributeType)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputArrayToProcess_59(base.GetCppThis(), idx, port, connection, fieldAssociation, fieldAttributeType);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetInputArrayToProcess_60(HandleRef pThis, int idx, HandleRef info);

		public virtual void SetInputArrayToProcess(int idx, vtkInformation info)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputArrayToProcess_60(base.GetCppThis(), idx, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetInputArrayToProcess_61(HandleRef pThis, int idx, int port, int connection, string fieldAssociation, string attributeTypeorName);

		public virtual void SetInputArrayToProcess(int idx, int port, int connection, string fieldAssociation, string attributeTypeorName)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputArrayToProcess_61(base.GetCppThis(), idx, port, connection, fieldAssociation, attributeTypeorName);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetInputConnection_62(HandleRef pThis, int port, HandleRef input);

		public virtual void SetInputConnection(int port, vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputConnection_62(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetInputConnection_63(HandleRef pThis, HandleRef input);

		public virtual void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkAlgorithm.vtkAlgorithm_SetInputConnection_63(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetProgress_64(HandleRef pThis, double _arg);

		public virtual void SetProgress(double _arg)
		{
			vtkAlgorithm.vtkAlgorithm_SetProgress_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetProgressText_65(HandleRef pThis, string ptext);

		public void SetProgressText(string ptext)
		{
			vtkAlgorithm.vtkAlgorithm_SetProgressText_65(base.GetCppThis(), ptext);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_SetReleaseDataFlag_66(HandleRef pThis, int arg0);

		public virtual void SetReleaseDataFlag(int arg0)
		{
			vtkAlgorithm.vtkAlgorithm_SetReleaseDataFlag_66(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_Update_68(HandleRef pThis);

		public virtual void Update()
		{
			vtkAlgorithm.vtkAlgorithm_Update_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_UpdateExtentIsEmpty_69(HandleRef pThis, HandleRef output);

		public int UpdateExtentIsEmpty(vtkDataObject output)
		{
			return vtkAlgorithm.vtkAlgorithm_UpdateExtentIsEmpty_69(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAlgorithm_UpdateExtentIsEmpty_70(HandleRef pThis, HandleRef pinfo, int extentType);

		public int UpdateExtentIsEmpty(vtkInformation pinfo, int extentType)
		{
			return vtkAlgorithm.vtkAlgorithm_UpdateExtentIsEmpty_70(base.GetCppThis(), (pinfo == null) ? default(HandleRef) : pinfo.GetCppThis(), extentType);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_UpdateInformation_71(HandleRef pThis);

		public virtual void UpdateInformation()
		{
			vtkAlgorithm.vtkAlgorithm_UpdateInformation_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_UpdateProgress_72(HandleRef pThis, double amount);

		public void UpdateProgress(double amount)
		{
			vtkAlgorithm.vtkAlgorithm_UpdateProgress_72(base.GetCppThis(), amount);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAlgorithm_UpdateWholeExtent_73(HandleRef pThis);

		public virtual void UpdateWholeExtent()
		{
			vtkAlgorithm.vtkAlgorithm_UpdateWholeExtent_73(base.GetCppThis());
		}
	}
}
