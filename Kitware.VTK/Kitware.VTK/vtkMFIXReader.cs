using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMFIXReader : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMFIXReader";

		public new static readonly string MRClassNameKey;

		static vtkMFIXReader()
		{
			vtkMFIXReader.MRClassNameKey = "class vtkMFIXReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMFIXReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMFIXReader"));
		}

		public vtkMFIXReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMFIXReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMFIXReader New()
		{
			vtkMFIXReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMFIXReader.vtkMFIXReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMFIXReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMFIXReader.vtkMFIXReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_DisableAllCellArrays_01(HandleRef pThis);

		public void DisableAllCellArrays()
		{
			vtkMFIXReader.vtkMFIXReader_DisableAllCellArrays_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_EnableAllCellArrays_02(HandleRef pThis);

		public void EnableAllCellArrays()
		{
			vtkMFIXReader.vtkMFIXReader_EnableAllCellArrays_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMFIXReader_GetCellArrayName_03(HandleRef pThis, int index);

		public string GetCellArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkMFIXReader.vtkMFIXReader_GetCellArrayName_03(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_GetCellArrayStatus_04(HandleRef pThis, string name);

		public int GetCellArrayStatus(string name)
		{
			return vtkMFIXReader.vtkMFIXReader_GetCellArrayStatus_04(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_GetCellDataRange_05(HandleRef pThis, int cellComp, int index, IntPtr min, IntPtr max);

		public void GetCellDataRange(int cellComp, int index, IntPtr min, IntPtr max)
		{
			vtkMFIXReader.vtkMFIXReader_GetCellDataRange_05(base.GetCppThis(), cellComp, index, min, max);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMFIXReader_GetFileName_06(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMFIXReader.vtkMFIXReader_GetFileName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_GetNumberOfCellArrays_07(HandleRef pThis);

		public int GetNumberOfCellArrays()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfCellArrays_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_GetNumberOfCellFields_08(HandleRef pThis);

		public virtual int GetNumberOfCellFields()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfCellFields_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_GetNumberOfCells_09(HandleRef pThis);

		public virtual int GetNumberOfCells()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfCells_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_GetNumberOfPoints_10(HandleRef pThis);

		public virtual int GetNumberOfPoints()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfPoints_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_GetNumberOfTimeSteps_11(HandleRef pThis);

		public virtual int GetNumberOfTimeSteps()
		{
			return vtkMFIXReader.vtkMFIXReader_GetNumberOfTimeSteps_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_GetTimeStep_12(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkMFIXReader.vtkMFIXReader_GetTimeStep_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMFIXReader_GetTimeStepRange_13(HandleRef pThis);

		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkMFIXReader.vtkMFIXReader_GetTimeStepRange_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_GetTimeStepRange_14(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkMFIXReader.vtkMFIXReader_GetTimeStepRange_14(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_GetTimeStepRange_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkMFIXReader.vtkMFIXReader_GetTimeStepRange_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMFIXReader.vtkMFIXReader_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMFIXReader_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMFIXReader.vtkMFIXReader_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMFIXReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMFIXReader NewInstance()
		{
			vtkMFIXReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMFIXReader.vtkMFIXReader_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMFIXReader_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMFIXReader SafeDownCast(vtkObjectBase o)
		{
			vtkMFIXReader vtkMFIXReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMFIXReader.vtkMFIXReader_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMFIXReader = (vtkMFIXReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMFIXReader.Register(null);
				}
			}
			return vtkMFIXReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_SetCellArrayStatus_21(HandleRef pThis, string name, int status);

		public void SetCellArrayStatus(string name, int status)
		{
			vtkMFIXReader.vtkMFIXReader_SetCellArrayStatus_21(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_SetFileName_22(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkMFIXReader.vtkMFIXReader_SetFileName_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_SetTimeStep_23(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkMFIXReader.vtkMFIXReader_SetTimeStep_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_SetTimeStepRange_24(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkMFIXReader.vtkMFIXReader_SetTimeStepRange_24(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMFIXReader_SetTimeStepRange_25(HandleRef pThis, IntPtr _arg);

		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkMFIXReader.vtkMFIXReader_SetTimeStepRange_25(base.GetCppThis(), _arg);
		}
	}
}
