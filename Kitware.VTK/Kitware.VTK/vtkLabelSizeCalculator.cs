using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLabelSizeCalculator : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelSizeCalculator";

		public new static readonly string MRClassNameKey;

		static vtkLabelSizeCalculator()
		{
			vtkLabelSizeCalculator.MRClassNameKey = "class vtkLabelSizeCalculator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelSizeCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelSizeCalculator"));
		}

		public vtkLabelSizeCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelSizeCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelSizeCalculator New()
		{
			vtkLabelSizeCalculator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelSizeCalculator.vtkLabelSizeCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLabelSizeCalculator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLabelSizeCalculator.vtkLabelSizeCalculator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelSizeCalculator_GetFontProperty_01(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetFontProperty(int type)
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelSizeCalculator.vtkLabelSizeCalculator_GetFontProperty_01(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelSizeCalculator_GetLabelSizeArrayName_02(HandleRef pThis);

		public virtual string GetLabelSizeArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkLabelSizeCalculator.vtkLabelSizeCalculator_GetLabelSizeArrayName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelSizeCalculator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabelSizeCalculator.vtkLabelSizeCalculator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelSizeCalculator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabelSizeCalculator.vtkLabelSizeCalculator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelSizeCalculator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabelSizeCalculator NewInstance()
		{
			vtkLabelSizeCalculator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelSizeCalculator.vtkLabelSizeCalculator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelSizeCalculator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelSizeCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkLabelSizeCalculator vtkLabelSizeCalculator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelSizeCalculator.vtkLabelSizeCalculator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelSizeCalculator = (vtkLabelSizeCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelSizeCalculator.Register(null);
				}
			}
			return vtkLabelSizeCalculator;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelSizeCalculator_SetFontProperty_08(HandleRef pThis, HandleRef fontProp, int type);

		public virtual void SetFontProperty(vtkTextProperty fontProp, int type)
		{
			vtkLabelSizeCalculator.vtkLabelSizeCalculator_SetFontProperty_08(base.GetCppThis(), (fontProp == null) ? default(HandleRef) : fontProp.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelSizeCalculator_SetLabelSizeArrayName_09(HandleRef pThis, string _arg);

		public virtual void SetLabelSizeArrayName(string _arg)
		{
			vtkLabelSizeCalculator.vtkLabelSizeCalculator_SetLabelSizeArrayName_09(base.GetCppThis(), _arg);
		}
	}
}
