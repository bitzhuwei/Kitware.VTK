using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStringToCategory : vtkDataObjectAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringToCategory";

		public new static readonly string MRClassNameKey;

		static vtkStringToCategory()
		{
			vtkStringToCategory.MRClassNameKey = "class vtkStringToCategory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringToCategory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToCategory"));
		}

		public vtkStringToCategory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToCategory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringToCategory New()
		{
			vtkStringToCategory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToCategory.vtkStringToCategory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToCategory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStringToCategory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStringToCategory.vtkStringToCategory_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToCategory_GetCategoryArrayName_01(HandleRef pThis);

		public virtual string GetCategoryArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkStringToCategory.vtkStringToCategory_GetCategoryArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStringToCategory_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStringToCategory.vtkStringToCategory_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkStringToCategory_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStringToCategory.vtkStringToCategory_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToCategory_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStringToCategory NewInstance()
		{
			vtkStringToCategory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToCategory.vtkStringToCategory_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToCategory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToCategory_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringToCategory SafeDownCast(vtkObjectBase o)
		{
			vtkStringToCategory vtkStringToCategory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToCategory.vtkStringToCategory_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringToCategory = (vtkStringToCategory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringToCategory.Register(null);
				}
			}
			return vtkStringToCategory;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkStringToCategory_SetCategoryArrayName_07(HandleRef pThis, string _arg);

		public virtual void SetCategoryArrayName(string _arg)
		{
			vtkStringToCategory.vtkStringToCategory_SetCategoryArrayName_07(base.GetCppThis(), _arg);
		}
	}
}
