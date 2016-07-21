using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWindBladeReader : vtkStructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindBladeReader";

		public new static readonly string MRClassNameKey;

		static vtkWindBladeReader()
		{
			vtkWindBladeReader.MRClassNameKey = "class vtkWindBladeReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindBladeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindBladeReader"));
		}

		public vtkWindBladeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindBladeReader New()
		{
			vtkWindBladeReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWindBladeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWindBladeReader.vtkWindBladeReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_DisableAllPointArrays_01(HandleRef pThis);

		public void DisableAllPointArrays()
		{
			vtkWindBladeReader.vtkWindBladeReader_DisableAllPointArrays_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_EnableAllPointArrays_02(HandleRef pThis);

		public void EnableAllPointArrays()
		{
			vtkWindBladeReader.vtkWindBladeReader_EnableAllPointArrays_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_GetBladeOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetBladeOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetBladeOutput_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_GetFieldOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredGrid GetFieldOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetFieldOutput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_GetFilename_05(HandleRef pThis);

		public virtual string GetFilename()
		{
			return Marshal.PtrToStringAnsi(vtkWindBladeReader.vtkWindBladeReader_GetFilename_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_GetGroundOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredGrid GetGroundOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetGroundOutput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkWindBladeReader_GetNumberOfPointArrays_07(HandleRef pThis);

		public int GetNumberOfPointArrays()
		{
			return vtkWindBladeReader.vtkWindBladeReader_GetNumberOfPointArrays_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_GetPointArrayName_08(HandleRef pThis, int index);

		public string GetPointArrayName(int index)
		{
			return Marshal.PtrToStringAnsi(vtkWindBladeReader.vtkWindBladeReader_GetPointArrayName_08(base.GetCppThis(), index));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkWindBladeReader_GetPointArrayStatus_09(HandleRef pThis, string name);

		public int GetPointArrayStatus(string name)
		{
			return vtkWindBladeReader.vtkWindBladeReader_GetPointArrayStatus_09(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_GetSubExtent_10(HandleRef pThis);

		public virtual int[] GetSubExtent()
		{
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetSubExtent_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_GetSubExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetSubExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkWindBladeReader.vtkWindBladeReader_GetSubExtent_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_GetSubExtent_12(HandleRef pThis, IntPtr _arg);

		public virtual void GetSubExtent(IntPtr _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_GetSubExtent_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_GetWholeExtent_13(HandleRef pThis);

		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetWholeExtent_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_GetWholeExtent_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkWindBladeReader.vtkWindBladeReader_GetWholeExtent_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_GetWholeExtent_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_GetWholeExtent_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkWindBladeReader_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWindBladeReader.vtkWindBladeReader_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkWindBladeReader_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWindBladeReader.vtkWindBladeReader_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWindBladeReader NewInstance()
		{
			vtkWindBladeReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkWindBladeReader_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindBladeReader SafeDownCast(vtkObjectBase o)
		{
			vtkWindBladeReader vtkWindBladeReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindBladeReader = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindBladeReader.Register(null);
				}
			}
			return vtkWindBladeReader;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_SetFilename_21(HandleRef pThis, string _arg);

		public virtual void SetFilename(string _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetFilename_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_SetPointArrayStatus_22(HandleRef pThis, string name, int status);

		public void SetPointArrayStatus(string name, int status)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetPointArrayStatus_22(base.GetCppThis(), name, status);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_SetSubExtent_23(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetSubExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetSubExtent_23(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_SetSubExtent_24(HandleRef pThis, IntPtr _arg);

		public virtual void SetSubExtent(IntPtr _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetSubExtent_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_SetWholeExtent_25(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetWholeExtent_25(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkWindBladeReader_SetWholeExtent_26(HandleRef pThis, IntPtr _arg);

		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetWholeExtent_26(base.GetCppThis(), _arg);
		}
	}
}
