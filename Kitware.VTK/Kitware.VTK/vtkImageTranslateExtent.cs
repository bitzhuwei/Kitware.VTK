using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageTranslateExtent : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageTranslateExtent";

		public new static readonly string MRClassNameKey;

		static vtkImageTranslateExtent()
		{
			vtkImageTranslateExtent.MRClassNameKey = "class vtkImageTranslateExtent";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageTranslateExtent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageTranslateExtent"));
		}

		public vtkImageTranslateExtent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTranslateExtent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageTranslateExtent New()
		{
			vtkImageTranslateExtent result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTranslateExtent.vtkImageTranslateExtent_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTranslateExtent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageTranslateExtent() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageTranslateExtent.vtkImageTranslateExtent_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTranslateExtent_GetTranslation_01(HandleRef pThis);

		public virtual int[] GetTranslation()
		{
			IntPtr intPtr = vtkImageTranslateExtent.vtkImageTranslateExtent_GetTranslation_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageTranslateExtent_GetTranslation_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetTranslation(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageTranslateExtent.vtkImageTranslateExtent_GetTranslation_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageTranslateExtent_GetTranslation_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetTranslation(IntPtr _arg)
		{
			vtkImageTranslateExtent.vtkImageTranslateExtent_GetTranslation_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageTranslateExtent_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageTranslateExtent.vtkImageTranslateExtent_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageTranslateExtent_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageTranslateExtent.vtkImageTranslateExtent_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTranslateExtent_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageTranslateExtent NewInstance()
		{
			vtkImageTranslateExtent result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTranslateExtent.vtkImageTranslateExtent_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageTranslateExtent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageTranslateExtent_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageTranslateExtent SafeDownCast(vtkObjectBase o)
		{
			vtkImageTranslateExtent vtkImageTranslateExtent = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageTranslateExtent.vtkImageTranslateExtent_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageTranslateExtent = (vtkImageTranslateExtent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageTranslateExtent.Register(null);
				}
			}
			return vtkImageTranslateExtent;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageTranslateExtent_SetTranslation_09(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetTranslation(int _arg1, int _arg2, int _arg3)
		{
			vtkImageTranslateExtent.vtkImageTranslateExtent_SetTranslation_09(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageTranslateExtent_SetTranslation_10(HandleRef pThis, IntPtr _arg);

		public virtual void SetTranslation(IntPtr _arg)
		{
			vtkImageTranslateExtent.vtkImageTranslateExtent_SetTranslation_10(base.GetCppThis(), _arg);
		}
	}
}
