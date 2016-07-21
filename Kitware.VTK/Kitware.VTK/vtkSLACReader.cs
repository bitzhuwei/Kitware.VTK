using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSLACReader : vtkMultiBlockDataSetAlgorithm
	{
		public enum NUM_OUTPUTS_WrapperEnum
		{
			NUM_OUTPUTS = 2,
			SURFACE_OUTPUT = 0,
			VOLUME_OUTPUT
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSLACReader";

		public new static readonly string MRClassNameKey;

		static vtkSLACReader()
		{
			vtkSLACReader.MRClassNameKey = "class vtkSLACReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSLACReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSLACReader"));
		}

		public vtkSLACReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSLACReader New()
		{
			vtkSLACReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSLACReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSLACReader.vtkSLACReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_AddModeFileName_01(HandleRef pThis, string fname);

		public virtual void AddModeFileName(string fname)
		{
			vtkSLACReader.vtkSLACReader_AddModeFileName_01(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACReader_CanReadFile_02(string filename);

		public static int CanReadFile(string filename)
		{
			return vtkSLACReader.vtkSLACReader_CanReadFile_02(filename);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_GetMeshFileName_03(HandleRef pThis);

		public virtual string GetMeshFileName()
		{
			return Marshal.PtrToStringAnsi(vtkSLACReader.vtkSLACReader_GetMeshFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_GetModeFileName_04(HandleRef pThis, uint idx);

		public virtual string GetModeFileName(uint idx)
		{
			return Marshal.PtrToStringAnsi(vtkSLACReader.vtkSLACReader_GetModeFileName_04(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkSLACReader_GetNumberOfModeFileNames_05(HandleRef pThis);

		public virtual uint GetNumberOfModeFileNames()
		{
			return vtkSLACReader.vtkSLACReader_GetNumberOfModeFileNames_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACReader_GetNumberOfVariableArrays_06(HandleRef pThis);

		public virtual int GetNumberOfVariableArrays()
		{
			return vtkSLACReader.vtkSLACReader_GetNumberOfVariableArrays_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACReader_GetReadExternalSurface_07(HandleRef pThis);

		public virtual int GetReadExternalSurface()
		{
			return vtkSLACReader.vtkSLACReader_GetReadExternalSurface_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACReader_GetReadInternalVolume_08(HandleRef pThis);

		public virtual int GetReadInternalVolume()
		{
			return vtkSLACReader.vtkSLACReader_GetReadInternalVolume_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACReader_GetReadMidpoints_09(HandleRef pThis);

		public virtual int GetReadMidpoints()
		{
			return vtkSLACReader.vtkSLACReader_GetReadMidpoints_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_GetVariableArrayName_10(HandleRef pThis, int idx);

		public virtual string GetVariableArrayName(int idx)
		{
			return Marshal.PtrToStringAnsi(vtkSLACReader.vtkSLACReader_GetVariableArrayName_10(base.GetCppThis(), idx));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACReader_GetVariableArrayStatus_11(HandleRef pThis, string name);

		public virtual int GetVariableArrayStatus(string name)
		{
			return vtkSLACReader.vtkSLACReader_GetVariableArrayStatus_11(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_IS_EXTERNAL_SURFACE_12(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey IS_EXTERNAL_SURFACE()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_IS_EXTERNAL_SURFACE_12(ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_IS_INTERNAL_VOLUME_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey IS_INTERNAL_VOLUME()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_IS_INTERNAL_VOLUME_13(ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACReader_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSLACReader.vtkSLACReader_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkSLACReader_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSLACReader.vtkSLACReader_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSLACReader NewInstance()
		{
			vtkSLACReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_POINTS_18(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationObjectBaseKey POINTS()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_POINTS_18(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_POINT_DATA_19(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationObjectBaseKey POINT_DATA()
		{
			vtkInformationObjectBaseKey vtkInformationObjectBaseKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_POINT_DATA_19(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationObjectBaseKey = (vtkInformationObjectBaseKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationObjectBaseKey.Register(null);
				}
			}
			return vtkInformationObjectBaseKey;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_ReadExternalSurfaceOff_20(HandleRef pThis);

		public virtual void ReadExternalSurfaceOff()
		{
			vtkSLACReader.vtkSLACReader_ReadExternalSurfaceOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_ReadExternalSurfaceOn_21(HandleRef pThis);

		public virtual void ReadExternalSurfaceOn()
		{
			vtkSLACReader.vtkSLACReader_ReadExternalSurfaceOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_ReadInternalVolumeOff_22(HandleRef pThis);

		public virtual void ReadInternalVolumeOff()
		{
			vtkSLACReader.vtkSLACReader_ReadInternalVolumeOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_ReadInternalVolumeOn_23(HandleRef pThis);

		public virtual void ReadInternalVolumeOn()
		{
			vtkSLACReader.vtkSLACReader_ReadInternalVolumeOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_ReadMidpointsOff_24(HandleRef pThis);

		public virtual void ReadMidpointsOff()
		{
			vtkSLACReader.vtkSLACReader_ReadMidpointsOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_ReadMidpointsOn_25(HandleRef pThis);

		public virtual void ReadMidpointsOn()
		{
			vtkSLACReader.vtkSLACReader_ReadMidpointsOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_RemoveAllModeFileNames_26(HandleRef pThis);

		public virtual void RemoveAllModeFileNames()
		{
			vtkSLACReader.vtkSLACReader_RemoveAllModeFileNames_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkSLACReader_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSLACReader SafeDownCast(vtkObjectBase o)
		{
			vtkSLACReader vtkSLACReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSLACReader.vtkSLACReader_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSLACReader = (vtkSLACReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSLACReader.Register(null);
				}
			}
			return vtkSLACReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_SetMeshFileName_28(HandleRef pThis, string _arg);

		public virtual void SetMeshFileName(string _arg)
		{
			vtkSLACReader.vtkSLACReader_SetMeshFileName_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_SetReadExternalSurface_29(HandleRef pThis, int _arg);

		public virtual void SetReadExternalSurface(int _arg)
		{
			vtkSLACReader.vtkSLACReader_SetReadExternalSurface_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_SetReadInternalVolume_30(HandleRef pThis, int _arg);

		public virtual void SetReadInternalVolume(int _arg)
		{
			vtkSLACReader.vtkSLACReader_SetReadInternalVolume_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_SetReadMidpoints_31(HandleRef pThis, int _arg);

		public virtual void SetReadMidpoints(int _arg)
		{
			vtkSLACReader.vtkSLACReader_SetReadMidpoints_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkSLACReader_SetVariableArrayStatus_32(HandleRef pThis, string name, int status);

		public virtual void SetVariableArrayStatus(string name, int status)
		{
			vtkSLACReader.vtkSLACReader_SetVariableArrayStatus_32(base.GetCppThis(), name, status);
		}
	}
}
