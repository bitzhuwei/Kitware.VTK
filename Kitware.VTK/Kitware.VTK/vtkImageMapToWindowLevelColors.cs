using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMapToWindowLevelColors : vtkImageMapToColors
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapToWindowLevelColors";

		public new static readonly string MRClassNameKey;

		static vtkImageMapToWindowLevelColors()
		{
			vtkImageMapToWindowLevelColors.MRClassNameKey = "class vtkImageMapToWindowLevelColors";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapToWindowLevelColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapToWindowLevelColors"));
		}

		public vtkImageMapToWindowLevelColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToWindowLevelColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMapToWindowLevelColors New()
		{
			vtkImageMapToWindowLevelColors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMapToWindowLevelColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageMapToWindowLevelColors_GetLevel_01(HandleRef pThis);

		public virtual double GetLevel()
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_GetLevel_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageMapToWindowLevelColors_GetWindow_02(HandleRef pThis);

		public virtual double GetWindow()
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_GetWindow_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToWindowLevelColors_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToWindowLevelColors_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToWindowLevelColors_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMapToWindowLevelColors NewInstance()
		{
			vtkImageMapToWindowLevelColors result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToWindowLevelColors_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMapToWindowLevelColors SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToWindowLevelColors = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToWindowLevelColors.Register(null);
				}
			}
			return vtkImageMapToWindowLevelColors;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToWindowLevelColors_SetLevel_08(HandleRef pThis, double _arg);

		public virtual void SetLevel(double _arg)
		{
			vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_SetLevel_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMapToWindowLevelColors_SetWindow_09(HandleRef pThis, double _arg);

		public virtual void SetWindow(double _arg)
		{
			vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_SetWindow_09(base.GetCppThis(), _arg);
		}
	}
}
