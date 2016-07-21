using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLReader : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLReader()
		{
			vtkXMLReader.MRClassNameKey = "class vtkXMLReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLReader"));
		}

		public vtkXMLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_CanReadFile_01(HandleRef pThis, string name);

		public virtual int CanReadFile(string name)
		{
			return vtkXMLReader.vtkXMLReader_CanReadFile_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_CopyOutputInformation_02(HandleRef pThis, HandleRef arg0, int arg1);

		public virtual void CopyOutputInformation(vtkInformation arg0, int arg1)
		{
			vtkXMLReader.vtkXMLReader_CopyOutputInformation_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), arg1);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_GetCellArrayName_03(HandleRef pThis, int index);

		public string GetCellArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetCellArrayName_03(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_GetCellArrayStatus_04(HandleRef pThis, string name);

		public int GetCellArrayStatus(string name)
		{
			return vtkXMLReader.vtkXMLReader_GetCellArrayStatus_04(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_GetCellDataArraySelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetCellDataArraySelection_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_GetFileName_06(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetFileName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_GetNumberOfCellArrays_07(HandleRef pThis);

		public int GetNumberOfCellArrays()
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfCellArrays_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_GetNumberOfPointArrays_08(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfPointArrays_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_GetNumberOfTimeSteps_09(HandleRef pThis);

		public virtual int GetNumberOfTimeSteps()
		{
			return vtkXMLReader.vtkXMLReader_GetNumberOfTimeSteps_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_GetOutputAsDataSet_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetOutputAsDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetOutputAsDataSet_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_GetOutputAsDataSet_11(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetOutputAsDataSet(int index)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetOutputAsDataSet_11(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_GetPointArrayName_12(HandleRef pThis, int index);

		public string GetPointArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkXMLReader.vtkXMLReader_GetPointArrayName_12(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_GetPointArrayStatus_13(HandleRef pThis, string name);

		public int GetPointArrayStatus(string name)
		{
			return vtkXMLReader.vtkXMLReader_GetPointArrayStatus_13(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_GetPointDataArraySelection_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetPointDataArraySelection_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_GetTimeStep_15(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkXMLReader.vtkXMLReader_GetTimeStep_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_GetTimeStepRange_16(HandleRef pThis);

		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_GetTimeStepRange_16(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_GetTimeStepRange_17(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkXMLReader.vtkXMLReader_GetTimeStepRange_17(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_GetTimeStepRange_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkXMLReader.vtkXMLReader_GetTimeStepRange_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLReader.vtkXMLReader_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLReader_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLReader.vtkXMLReader_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLReader NewInstance()
		{
			vtkXMLReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLReader vtkXMLReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLReader.vtkXMLReader_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLReader = (vtkXMLReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLReader.Register(null);
				}
			}
			return vtkXMLReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_SetCellArrayStatus_23(HandleRef pThis, string name, int status);

		public void SetCellArrayStatus(string name, int status)
		{
			vtkXMLReader.vtkXMLReader_SetCellArrayStatus_23(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_SetFileName_24(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkXMLReader.vtkXMLReader_SetFileName_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_SetPointArrayStatus_25(HandleRef pThis, string name, int status);

		public void SetPointArrayStatus(string name, int status)
		{
			vtkXMLReader.vtkXMLReader_SetPointArrayStatus_25(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_SetTimeStep_26(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkXMLReader.vtkXMLReader_SetTimeStep_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_SetTimeStepRange_27(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkXMLReader.vtkXMLReader_SetTimeStepRange_27(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLReader_SetTimeStepRange_28(HandleRef pThis, IntPtr _arg);

		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkXMLReader.vtkXMLReader_SetTimeStepRange_28(base.GetCppThis(), _arg);
		}
	}
}
