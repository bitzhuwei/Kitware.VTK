using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMaskFields : vtkDataSetAlgorithm
	{
		public enum FieldLocation
		{
			CELL_DATA = 2,
			OBJECT_DATA = 0,
			POINT_DATA
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkMaskFields";

		public new static readonly string MRClassNameKey;

		static vtkMaskFields()
		{
			vtkMaskFields.MRClassNameKey = "class vtkMaskFields";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMaskFields.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskFields"));
		}

		public vtkMaskFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMaskFields New()
		{
			vtkMaskFields result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskFields.vtkMaskFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMaskFields() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMaskFields.vtkMaskFields_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyAllOff_01(HandleRef pThis);

		public virtual void CopyAllOff()
		{
			vtkMaskFields.vtkMaskFields_CopyAllOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyAllOn_02(HandleRef pThis);

		public virtual void CopyAllOn()
		{
			vtkMaskFields.vtkMaskFields_CopyAllOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyAttributeOff_03(HandleRef pThis, int attributeLocation, int attributeType);

		public void CopyAttributeOff(int attributeLocation, int attributeType)
		{
			vtkMaskFields.vtkMaskFields_CopyAttributeOff_03(base.GetCppThis(), attributeLocation, attributeType);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyAttributeOff_04(HandleRef pThis, string attributeLoc, string attributeType);

		public void CopyAttributeOff(string attributeLoc, string attributeType)
		{
			vtkMaskFields.vtkMaskFields_CopyAttributeOff_04(base.GetCppThis(), attributeLoc, attributeType);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyAttributeOn_05(HandleRef pThis, int attributeLocation, int attributeType);

		public void CopyAttributeOn(int attributeLocation, int attributeType)
		{
			vtkMaskFields.vtkMaskFields_CopyAttributeOn_05(base.GetCppThis(), attributeLocation, attributeType);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyAttributeOn_06(HandleRef pThis, string attributeLoc, string attributeType);

		public void CopyAttributeOn(string attributeLoc, string attributeType)
		{
			vtkMaskFields.vtkMaskFields_CopyAttributeOn_06(base.GetCppThis(), attributeLoc, attributeType);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyAttributesOff_07(HandleRef pThis);

		public void CopyAttributesOff()
		{
			vtkMaskFields.vtkMaskFields_CopyAttributesOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyAttributesOn_08(HandleRef pThis);

		public void CopyAttributesOn()
		{
			vtkMaskFields.vtkMaskFields_CopyAttributesOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyFieldOff_09(HandleRef pThis, int fieldLocation, string name);

		public void CopyFieldOff(int fieldLocation, string name)
		{
			vtkMaskFields.vtkMaskFields_CopyFieldOff_09(base.GetCppThis(), fieldLocation, name);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyFieldOff_10(HandleRef pThis, string fieldLoc, string name);

		public void CopyFieldOff(string fieldLoc, string name)
		{
			vtkMaskFields.vtkMaskFields_CopyFieldOff_10(base.GetCppThis(), fieldLoc, name);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyFieldOn_11(HandleRef pThis, int fieldLocation, string name);

		public void CopyFieldOn(int fieldLocation, string name)
		{
			vtkMaskFields.vtkMaskFields_CopyFieldOn_11(base.GetCppThis(), fieldLocation, name);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyFieldOn_12(HandleRef pThis, string fieldLoc, string name);

		public void CopyFieldOn(string fieldLoc, string name)
		{
			vtkMaskFields.vtkMaskFields_CopyFieldOn_12(base.GetCppThis(), fieldLoc, name);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyFieldsOff_13(HandleRef pThis);

		public void CopyFieldsOff()
		{
			vtkMaskFields.vtkMaskFields_CopyFieldsOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskFields_CopyFieldsOn_14(HandleRef pThis);

		public void CopyFieldsOn()
		{
			vtkMaskFields.vtkMaskFields_CopyFieldsOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskFields_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMaskFields.vtkMaskFields_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskFields_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMaskFields.vtkMaskFields_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskFields_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMaskFields NewInstance()
		{
			vtkMaskFields result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskFields.vtkMaskFields_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskFields_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMaskFields SafeDownCast(vtkObjectBase o)
		{
			vtkMaskFields vtkMaskFields = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskFields.vtkMaskFields_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMaskFields = (vtkMaskFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMaskFields.Register(null);
				}
			}
			return vtkMaskFields;
		}
	}
}
