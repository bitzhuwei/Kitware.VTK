using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractVOI : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractVOI";

		public new static readonly string MRClassNameKey;

		static vtkExtractVOI()
		{
			vtkExtractVOI.MRClassNameKey = "class vtkExtractVOI";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractVOI.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractVOI"));
		}

		public vtkExtractVOI(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVOI_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractVOI New()
		{
			vtkExtractVOI result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractVOI() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractVOI.vtkExtractVOI_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVOI_GetSampleRate_01(HandleRef pThis);

		public virtual int[] GetSampleRate()
		{
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_GetSampleRate_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkExtractVOI_GetSampleRate_02(HandleRef pThis, IntPtr data);

		public virtual void GetSampleRate(IntPtr data)
		{
			vtkExtractVOI.vtkExtractVOI_GetSampleRate_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVOI_GetVOI_03(HandleRef pThis);

		public virtual int[] GetVOI()
		{
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_GetVOI_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkExtractVOI_GetVOI_04(HandleRef pThis, IntPtr data);

		public virtual void GetVOI(IntPtr data)
		{
			vtkExtractVOI.vtkExtractVOI_GetVOI_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkExtractVOI_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractVOI.vtkExtractVOI_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkExtractVOI_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractVOI.vtkExtractVOI_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVOI_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractVOI NewInstance()
		{
			vtkExtractVOI result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractVOI_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractVOI SafeDownCast(vtkObjectBase o)
		{
			vtkExtractVOI vtkExtractVOI = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractVOI.vtkExtractVOI_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractVOI = (vtkExtractVOI)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractVOI.Register(null);
				}
			}
			return vtkExtractVOI;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkExtractVOI_SetSampleRate_10(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetSampleRate(int _arg1, int _arg2, int _arg3)
		{
			vtkExtractVOI.vtkExtractVOI_SetSampleRate_10(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkExtractVOI_SetSampleRate_11(HandleRef pThis, IntPtr _arg);

		public virtual void SetSampleRate(IntPtr _arg)
		{
			vtkExtractVOI.vtkExtractVOI_SetSampleRate_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkExtractVOI_SetVOI_12(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractVOI.vtkExtractVOI_SetVOI_12(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkExtractVOI_SetVOI_13(HandleRef pThis, IntPtr _arg);

		public virtual void SetVOI(IntPtr _arg)
		{
			vtkExtractVOI.vtkExtractVOI_SetVOI_13(base.GetCppThis(), _arg);
		}
	}
}
