using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageExtractComponents : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageExtractComponents";

		public new static readonly string MRClassNameKey;

		static vtkImageExtractComponents()
		{
			vtkImageExtractComponents.MRClassNameKey = "class vtkImageExtractComponents";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageExtractComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageExtractComponents"));
		}

		public vtkImageExtractComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExtractComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageExtractComponents New()
		{
			vtkImageExtractComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageExtractComponents.vtkImageExtractComponents_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageExtractComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageExtractComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageExtractComponents.vtkImageExtractComponents_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExtractComponents_GetComponents_01(HandleRef pThis);

		public virtual int[] GetComponents()
		{
			IntPtr intPtr = vtkImageExtractComponents.vtkImageExtractComponents_GetComponents_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExtractComponents_GetComponents_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetComponents(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_GetComponents_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExtractComponents_GetComponents_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetComponents(IntPtr _arg)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_GetComponents_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExtractComponents_GetNumberOfComponents_04(HandleRef pThis);

		public virtual int GetNumberOfComponents()
		{
			return vtkImageExtractComponents.vtkImageExtractComponents_GetNumberOfComponents_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExtractComponents_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageExtractComponents.vtkImageExtractComponents_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageExtractComponents_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageExtractComponents.vtkImageExtractComponents_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExtractComponents_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageExtractComponents NewInstance()
		{
			vtkImageExtractComponents result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageExtractComponents.vtkImageExtractComponents_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageExtractComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageExtractComponents_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageExtractComponents SafeDownCast(vtkObjectBase o)
		{
			vtkImageExtractComponents vtkImageExtractComponents = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageExtractComponents.vtkImageExtractComponents_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageExtractComponents = (vtkImageExtractComponents)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageExtractComponents.Register(null);
				}
			}
			return vtkImageExtractComponents;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExtractComponents_SetComponents_10(HandleRef pThis, int c1);

		public void SetComponents(int c1)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_SetComponents_10(base.GetCppThis(), c1);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExtractComponents_SetComponents_11(HandleRef pThis, int c1, int c2);

		public void SetComponents(int c1, int c2)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_SetComponents_11(base.GetCppThis(), c1, c2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageExtractComponents_SetComponents_12(HandleRef pThis, int c1, int c2, int c3);

		public void SetComponents(int c1, int c2, int c3)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_SetComponents_12(base.GetCppThis(), c1, c2, c3);
		}
	}
}
