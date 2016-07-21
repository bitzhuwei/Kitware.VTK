using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVRMLImporter : vtkImporter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRMLImporter";

		public new static readonly string MRClassNameKey;

		static vtkVRMLImporter()
		{
			vtkVRMLImporter.MRClassNameKey = "class vtkVRMLImporter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRMLImporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRMLImporter"));
		}

		public vtkVRMLImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVRMLImporter New()
		{
			vtkVRMLImporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVRMLImporter.vtkVRMLImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVRMLImporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVRMLImporter.vtkVRMLImporter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLImporter_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkVRMLImporter.vtkVRMLImporter_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLImporter_GetVRMLDEFObject_02(HandleRef pThis, string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkObject GetVRMLDEFObject(string name)
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVRMLImporter.vtkVRMLImporter_GetVRMLDEFObject_02(base.GetCppThis(), name, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVRMLImporter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVRMLImporter.vtkVRMLImporter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkVRMLImporter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVRMLImporter.vtkVRMLImporter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLImporter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVRMLImporter NewInstance()
		{
			vtkVRMLImporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVRMLImporter.vtkVRMLImporter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkVRMLImporter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVRMLImporter SafeDownCast(vtkObjectBase o)
		{
			vtkVRMLImporter vtkVRMLImporter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVRMLImporter.vtkVRMLImporter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRMLImporter = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRMLImporter.Register(null);
				}
			}
			return vtkVRMLImporter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVRMLImporter_SetFileName_08(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkVRMLImporter.vtkVRMLImporter_SetFileName_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVRMLImporter_enterField_09(HandleRef pThis, string arg0);

		public void enterField(string arg0)
		{
			vtkVRMLImporter.vtkVRMLImporter_enterField_09(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVRMLImporter_enterNode_10(HandleRef pThis, string arg0);

		public void enterNode(string arg0)
		{
			vtkVRMLImporter.vtkVRMLImporter_enterNode_10(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVRMLImporter_exitField_11(HandleRef pThis);

		public void exitField()
		{
			vtkVRMLImporter.vtkVRMLImporter_exitField_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVRMLImporter_exitNode_12(HandleRef pThis);

		public void exitNode()
		{
			vtkVRMLImporter.vtkVRMLImporter_exitNode_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkVRMLImporter_useNode_13(HandleRef pThis, string arg0);

		public void useNode(string arg0)
		{
			vtkVRMLImporter.vtkVRMLImporter_useNode_13(base.GetCppThis(), arg0);
		}
	}
}
