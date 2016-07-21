using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRemoveIsolatedVertices : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRemoveIsolatedVertices";

		public new static readonly string MRClassNameKey;

		static vtkRemoveIsolatedVertices()
		{
			vtkRemoveIsolatedVertices.MRClassNameKey = "class vtkRemoveIsolatedVertices";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRemoveIsolatedVertices.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemoveIsolatedVertices"));
		}

		public vtkRemoveIsolatedVertices(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRemoveIsolatedVertices_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRemoveIsolatedVertices New()
		{
			vtkRemoveIsolatedVertices result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveIsolatedVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRemoveIsolatedVertices() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRemoveIsolatedVertices_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRemoveIsolatedVertices_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRemoveIsolatedVertices_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRemoveIsolatedVertices NewInstance()
		{
			vtkRemoveIsolatedVertices result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveIsolatedVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRemoveIsolatedVertices_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRemoveIsolatedVertices SafeDownCast(vtkObjectBase o)
		{
			vtkRemoveIsolatedVertices vtkRemoveIsolatedVertices = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRemoveIsolatedVertices = (vtkRemoveIsolatedVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRemoveIsolatedVertices.Register(null);
				}
			}
			return vtkRemoveIsolatedVertices;
		}
	}
}
