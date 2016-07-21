using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPOPReader : vtkStructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPOPReader";

		public new static readonly string MRClassNameKey;

		static vtkPOPReader()
		{
			vtkPOPReader.MRClassNameKey = "class vtkPOPReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOPReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOPReader"));
		}

		public vtkPOPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPOPReader New()
		{
			vtkPOPReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOPReader.vtkPOPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPOPReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPOPReader.vtkPOPReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_GetClipExtent_01(HandleRef pThis);

		public virtual int[] GetClipExtent()
		{
			IntPtr intPtr = vtkPOPReader.vtkPOPReader_GetClipExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_GetClipExtent_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetClipExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkPOPReader.vtkPOPReader_GetClipExtent_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_GetClipExtent_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetClipExtent(IntPtr _arg)
		{
			vtkPOPReader.vtkPOPReader_GetClipExtent_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_GetDimensions_04(HandleRef pThis);

		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkPOPReader.vtkPOPReader_GetDimensions_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_GetDimensions_05(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetDimensions(ref int _arg1, ref int _arg2)
		{
			vtkPOPReader.vtkPOPReader_GetDimensions_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_GetDimensions_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetDimensions(IntPtr _arg)
		{
			vtkPOPReader.vtkPOPReader_GetDimensions_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_GetFileName_07(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPOPReader.vtkPOPReader_GetFileName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_GetGridFileName_08(HandleRef pThis);

		public virtual string GetGridFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPOPReader.vtkPOPReader_GetGridFileName_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPOPReader_GetNumberOfGhostLevels_09(HandleRef pThis);

		public virtual int GetNumberOfGhostLevels()
		{
			return vtkPOPReader.vtkPOPReader_GetNumberOfGhostLevels_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkPOPReader_GetRadius_10(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkPOPReader.vtkPOPReader_GetRadius_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_GetUFlowFileName_11(HandleRef pThis);

		public virtual string GetUFlowFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPOPReader.vtkPOPReader_GetUFlowFileName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_GetVFlowFileName_12(HandleRef pThis);

		public virtual string GetVFlowFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPOPReader.vtkPOPReader_GetVFlowFileName_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPOPReader_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPOPReader.vtkPOPReader_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPOPReader_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPOPReader.vtkPOPReader_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPOPReader NewInstance()
		{
			vtkPOPReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOPReader.vtkPOPReader_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPOPReader_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPOPReader SafeDownCast(vtkObjectBase o)
		{
			vtkPOPReader vtkPOPReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPOPReader.vtkPOPReader_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPOPReader = (vtkPOPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPOPReader.Register(null);
				}
			}
			return vtkPOPReader;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_SetClipExtent_18(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetClipExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkPOPReader.vtkPOPReader_SetClipExtent_18(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_SetClipExtent_19(HandleRef pThis, IntPtr _arg);

		public virtual void SetClipExtent(IntPtr _arg)
		{
			vtkPOPReader.vtkPOPReader_SetClipExtent_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_SetFileName_20(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkPOPReader.vtkPOPReader_SetFileName_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_SetNumberOfGhostLevels_21(HandleRef pThis, int _arg);

		public virtual void SetNumberOfGhostLevels(int _arg)
		{
			vtkPOPReader.vtkPOPReader_SetNumberOfGhostLevels_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPOPReader_SetRadius_22(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkPOPReader.vtkPOPReader_SetRadius_22(base.GetCppThis(), _arg);
		}
	}
}
