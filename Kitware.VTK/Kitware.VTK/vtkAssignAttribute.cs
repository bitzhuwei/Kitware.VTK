using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAssignAttribute : vtkPassInputTypeAlgorithm
	{
		public enum AttributeLocation
		{
			CELL_DATA = 1,
			EDGE_DATA = 3,
			NUM_ATTRIBUTE_LOCS,
			POINT_DATA = 0,
			VERTEX_DATA = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAssignAttribute";

		public new static readonly string MRClassNameKey;

		static vtkAssignAttribute()
		{
			vtkAssignAttribute.MRClassNameKey = "class vtkAssignAttribute";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssignAttribute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssignAttribute"));
		}

		public vtkAssignAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignAttribute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssignAttribute New()
		{
			vtkAssignAttribute result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignAttribute.vtkAssignAttribute_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAssignAttribute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAssignAttribute.vtkAssignAttribute_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAssignAttribute_Assign_01(HandleRef pThis, int inputAttributeType, int attributeType, int attributeLoc);

		public void Assign(int inputAttributeType, int attributeType, int attributeLoc)
		{
			vtkAssignAttribute.vtkAssignAttribute_Assign_01(base.GetCppThis(), inputAttributeType, attributeType, attributeLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAssignAttribute_Assign_02(HandleRef pThis, string fieldName, int attributeType, int attributeLoc);

		public void Assign(string fieldName, int attributeType, int attributeLoc)
		{
			vtkAssignAttribute.vtkAssignAttribute_Assign_02(base.GetCppThis(), fieldName, attributeType, attributeLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkAssignAttribute_Assign_03(HandleRef pThis, string name, string attributeType, string attributeLoc);

		public void Assign(string name, string attributeType, string attributeLoc)
		{
			vtkAssignAttribute.vtkAssignAttribute_Assign_03(base.GetCppThis(), name, attributeType, attributeLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAssignAttribute_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAssignAttribute.vtkAssignAttribute_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkAssignAttribute_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAssignAttribute.vtkAssignAttribute_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignAttribute_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAssignAttribute NewInstance()
		{
			vtkAssignAttribute result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignAttribute.vtkAssignAttribute_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkAssignAttribute_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssignAttribute SafeDownCast(vtkObjectBase o)
		{
			vtkAssignAttribute vtkAssignAttribute = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssignAttribute.vtkAssignAttribute_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssignAttribute = (vtkAssignAttribute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssignAttribute.Register(null);
				}
			}
			return vtkAssignAttribute;
		}
	}
}
