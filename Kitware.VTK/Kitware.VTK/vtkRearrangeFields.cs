using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRearrangeFields : vtkDataSetAlgorithm
	{
		public enum FieldLocation
		{
			CELL_DATA = 2,
			DATA_OBJECT = 0,
			POINT_DATA
		}

		public enum FieldType
		{
			ATTRIBUTE = 1,
			NAME = 0
		}

		public enum OperationType
		{
			COPY,
			MOVE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkRearrangeFields";

		public new static readonly string MRClassNameKey;

		static vtkRearrangeFields()
		{
			vtkRearrangeFields.MRClassNameKey = "class vtkRearrangeFields";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRearrangeFields.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRearrangeFields"));
		}

		public vtkRearrangeFields(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRearrangeFields_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRearrangeFields New()
		{
			vtkRearrangeFields result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRearrangeFields.vtkRearrangeFields_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRearrangeFields() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRearrangeFields.vtkRearrangeFields_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_AddOperation_01(HandleRef pThis, int operationType, int attributeType, int fromFieldLoc, int toFieldLoc);

		public int AddOperation(int operationType, int attributeType, int fromFieldLoc, int toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_AddOperation_01(base.GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_AddOperation_02(HandleRef pThis, int operationType, string name, int fromFieldLoc, int toFieldLoc);

		public int AddOperation(int operationType, string name, int fromFieldLoc, int toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_AddOperation_02(base.GetCppThis(), operationType, name, fromFieldLoc, toFieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_AddOperation_03(HandleRef pThis, string operationType, string attributeType, string fromFieldLoc, string toFieldLoc);

		public int AddOperation(string operationType, string attributeType, string fromFieldLoc, string toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_AddOperation_03(base.GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRearrangeFields.vtkRearrangeFields_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRearrangeFields.vtkRearrangeFields_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRearrangeFields_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRearrangeFields NewInstance()
		{
			vtkRearrangeFields result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRearrangeFields.vtkRearrangeFields_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRearrangeFields_RemoveAllOperations_08(HandleRef pThis);

		public void RemoveAllOperations()
		{
			vtkRearrangeFields.vtkRearrangeFields_RemoveAllOperations_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_RemoveOperation_09(HandleRef pThis, int operationId);

		public int RemoveOperation(int operationId)
		{
			return vtkRearrangeFields.vtkRearrangeFields_RemoveOperation_09(base.GetCppThis(), operationId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_RemoveOperation_10(HandleRef pThis, int operationType, int attributeType, int fromFieldLoc, int toFieldLoc);

		public int RemoveOperation(int operationType, int attributeType, int fromFieldLoc, int toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_RemoveOperation_10(base.GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_RemoveOperation_11(HandleRef pThis, int operationType, string name, int fromFieldLoc, int toFieldLoc);

		public int RemoveOperation(int operationType, string name, int fromFieldLoc, int toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_RemoveOperation_11(base.GetCppThis(), operationType, name, fromFieldLoc, toFieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRearrangeFields_RemoveOperation_12(HandleRef pThis, string operationType, string attributeType, string fromFieldLoc, string toFieldLoc);

		public int RemoveOperation(string operationType, string attributeType, string fromFieldLoc, string toFieldLoc)
		{
			return vtkRearrangeFields.vtkRearrangeFields_RemoveOperation_12(base.GetCppThis(), operationType, attributeType, fromFieldLoc, toFieldLoc);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRearrangeFields_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRearrangeFields SafeDownCast(vtkObjectBase o)
		{
			vtkRearrangeFields vtkRearrangeFields = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRearrangeFields.vtkRearrangeFields_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRearrangeFields = (vtkRearrangeFields)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRearrangeFields.Register(null);
				}
			}
			return vtkRearrangeFields;
		}
	}
}
