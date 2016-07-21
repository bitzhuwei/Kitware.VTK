using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGroupLeafVertices : vtkTreeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGroupLeafVertices";

		public new static readonly string MRClassNameKey;

		static vtkGroupLeafVertices()
		{
			vtkGroupLeafVertices.MRClassNameKey = "class vtkGroupLeafVertices";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGroupLeafVertices.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGroupLeafVertices"));
		}

		public vtkGroupLeafVertices(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGroupLeafVertices_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGroupLeafVertices New()
		{
			vtkGroupLeafVertices result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGroupLeafVertices.vtkGroupLeafVertices_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGroupLeafVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGroupLeafVertices() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGroupLeafVertices.vtkGroupLeafVertices_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGroupLeafVertices_GetGroupDomain_01(HandleRef pThis);

		public virtual string GetGroupDomain()
		{
			return Marshal.PtrToStringAnsi(vtkGroupLeafVertices.vtkGroupLeafVertices_GetGroupDomain_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGroupLeafVertices_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGroupLeafVertices.vtkGroupLeafVertices_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGroupLeafVertices_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGroupLeafVertices.vtkGroupLeafVertices_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGroupLeafVertices_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGroupLeafVertices NewInstance()
		{
			vtkGroupLeafVertices result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGroupLeafVertices.vtkGroupLeafVertices_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGroupLeafVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGroupLeafVertices_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGroupLeafVertices SafeDownCast(vtkObjectBase o)
		{
			vtkGroupLeafVertices vtkGroupLeafVertices = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGroupLeafVertices.vtkGroupLeafVertices_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGroupLeafVertices = (vtkGroupLeafVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGroupLeafVertices.Register(null);
				}
			}
			return vtkGroupLeafVertices;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGroupLeafVertices_SetGroupDomain_07(HandleRef pThis, string _arg);

		public virtual void SetGroupDomain(string _arg)
		{
			vtkGroupLeafVertices.vtkGroupLeafVertices_SetGroupDomain_07(base.GetCppThis(), _arg);
		}
	}
}
