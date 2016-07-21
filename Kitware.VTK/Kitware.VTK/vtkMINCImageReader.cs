using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMINCImageReader : vtkImageReader2
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageReader";

		public new static readonly string MRClassNameKey;

		static vtkMINCImageReader()
		{
			vtkMINCImageReader.MRClassNameKey = "class vtkMINCImageReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMINCImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageReader"));
		}

		public vtkMINCImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMINCImageReader New()
		{
			vtkMINCImageReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMINCImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMINCImageReader.vtkMINCImageReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageReader_CanReadFile_01(HandleRef pThis, string name);

		public override int CanReadFile(string name)
		{
			return vtkMINCImageReader.vtkMINCImageReader_CanReadFile_01(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageReader_GetDataRange_02(HandleRef pThis);

		public virtual double[] GetDataRange()
		{
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_GetDataRange_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageReader_GetDataRange_03(HandleRef pThis, IntPtr range);

		public virtual void GetDataRange(IntPtr range)
		{
			vtkMINCImageReader.vtkMINCImageReader_GetDataRange_03(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageReader_GetDescriptiveName_04(HandleRef pThis);

		public override string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkMINCImageReader.vtkMINCImageReader_GetDescriptiveName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageReader_GetDirectionCosines_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetDirectionCosines()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_GetDirectionCosines_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageReader_GetFileExtensions_06(HandleRef pThis);

		public override string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkMINCImageReader.vtkMINCImageReader_GetFileExtensions_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageReader_GetImageAttributes_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMINCImageAttributes GetImageAttributes()
		{
			vtkMINCImageAttributes vtkMINCImageAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_GetImageAttributes_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageAttributes = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageAttributes.Register(null);
				}
			}
			return vtkMINCImageAttributes;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageReader_GetNumberOfTimeSteps_08(HandleRef pThis);

		public virtual int GetNumberOfTimeSteps()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetNumberOfTimeSteps_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMINCImageReader_GetRescaleIntercept_09(HandleRef pThis);

		public virtual double GetRescaleIntercept()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetRescaleIntercept_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageReader_GetRescaleRealValues_10(HandleRef pThis);

		public virtual int GetRescaleRealValues()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetRescaleRealValues_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMINCImageReader_GetRescaleSlope_11(HandleRef pThis);

		public virtual double GetRescaleSlope()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetRescaleSlope_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageReader_GetTimeStep_12(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetTimeStep_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageReader_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMINCImageReader.vtkMINCImageReader_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMINCImageReader_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMINCImageReader.vtkMINCImageReader_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMINCImageReader NewInstance()
		{
			vtkMINCImageReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageReader_RescaleRealValuesOff_17(HandleRef pThis);

		public virtual void RescaleRealValuesOff()
		{
			vtkMINCImageReader.vtkMINCImageReader_RescaleRealValuesOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageReader_RescaleRealValuesOn_18(HandleRef pThis);

		public virtual void RescaleRealValuesOn()
		{
			vtkMINCImageReader.vtkMINCImageReader_RescaleRealValuesOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMINCImageReader_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMINCImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkMINCImageReader vtkMINCImageReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageReader = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageReader.Register(null);
				}
			}
			return vtkMINCImageReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageReader_SetFileName_20(HandleRef pThis, string name);

		public override void SetFileName(string name)
		{
			vtkMINCImageReader.vtkMINCImageReader_SetFileName_20(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageReader_SetRescaleRealValues_21(HandleRef pThis, int _arg);

		public virtual void SetRescaleRealValues(int _arg)
		{
			vtkMINCImageReader.vtkMINCImageReader_SetRescaleRealValues_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMINCImageReader_SetTimeStep_22(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkMINCImageReader.vtkMINCImageReader_SetTimeStep_22(base.GetCppThis(), _arg);
		}
	}
}
