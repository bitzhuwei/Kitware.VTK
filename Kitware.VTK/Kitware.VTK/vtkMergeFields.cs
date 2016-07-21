using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMergeFields : vtkDataSetAlgorithm
	{
		public enum FieldLocations
		{
			CELL_DATA = 2,
			DATA_OBJECT = 0,
			POINT_DATA
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeFields";

		public new static readonly string MRClassNameKey;

		static vtkMergeFields()
		{
			vtkMergeFields.MRClassNameKey = "class vtkMergeFields";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeFields.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeFields"));
		}

		public vtkMergeFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeFields New()
		{
			vtkMergeFields result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeFields.vtkMergeFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMergeFields() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMergeFields.vtkMergeFields_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeFields_GetNumberOfComponents_01(HandleRef pThis);

		public virtual int GetNumberOfComponents()
		{
			return vtkMergeFields.vtkMergeFields_GetNumberOfComponents_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeFields_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMergeFields.vtkMergeFields_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMergeFields_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMergeFields.vtkMergeFields_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeFields_Merge_04(HandleRef pThis, int component, string arrayName, int sourceComp);

		public void Merge(int component, string arrayName, int sourceComp)
		{
			vtkMergeFields.vtkMergeFields_Merge_04(base.GetCppThis(), component, arrayName, sourceComp);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeFields_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMergeFields NewInstance()
		{
			vtkMergeFields result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeFields.vtkMergeFields_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeFields_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeFields SafeDownCast(vtkObjectBase o)
		{
			vtkMergeFields vtkMergeFields = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeFields.vtkMergeFields_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeFields = (vtkMergeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeFields.Register(null);
				}
			}
			return vtkMergeFields;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeFields_SetNumberOfComponents_08(HandleRef pThis, int _arg);

		public virtual void SetNumberOfComponents(int _arg)
		{
			vtkMergeFields.vtkMergeFields_SetNumberOfComponents_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeFields_SetOutputField_09(HandleRef pThis, string name, int fieldLoc);

		public void SetOutputField(string name, int fieldLoc)
		{
			vtkMergeFields.vtkMergeFields_SetOutputField_09(base.GetCppThis(), name, fieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMergeFields_SetOutputField_10(HandleRef pThis, string name, string fieldLoc);

		public void SetOutputField(string name, string fieldLoc)
		{
			vtkMergeFields.vtkMergeFields_SetOutputField_10(base.GetCppThis(), name, fieldLoc);
		}
	}
}
