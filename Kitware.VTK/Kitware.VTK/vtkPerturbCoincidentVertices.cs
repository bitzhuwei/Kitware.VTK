using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPerturbCoincidentVertices : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPerturbCoincidentVertices";

		public new static readonly string MRClassNameKey;

		static vtkPerturbCoincidentVertices()
		{
			vtkPerturbCoincidentVertices.MRClassNameKey = "class vtkPerturbCoincidentVertices";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPerturbCoincidentVertices.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerturbCoincidentVertices"));
		}

		public vtkPerturbCoincidentVertices(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPerturbCoincidentVertices_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPerturbCoincidentVertices New()
		{
			vtkPerturbCoincidentVertices result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPerturbCoincidentVertices() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkPerturbCoincidentVertices_GetPerturbFactor_01(HandleRef pThis);

		public virtual double GetPerturbFactor()
		{
			return vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_GetPerturbFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPerturbCoincidentVertices_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPerturbCoincidentVertices_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPerturbCoincidentVertices_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPerturbCoincidentVertices NewInstance()
		{
			vtkPerturbCoincidentVertices result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPerturbCoincidentVertices_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPerturbCoincidentVertices SafeDownCast(vtkObjectBase o)
		{
			vtkPerturbCoincidentVertices vtkPerturbCoincidentVertices = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPerturbCoincidentVertices = (vtkPerturbCoincidentVertices)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPerturbCoincidentVertices.Register(null);
				}
			}
			return vtkPerturbCoincidentVertices;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPerturbCoincidentVertices_SetPerturbFactor_07(HandleRef pThis, double _arg);

		public virtual void SetPerturbFactor(double _arg)
		{
			vtkPerturbCoincidentVertices.vtkPerturbCoincidentVertices_SetPerturbFactor_07(base.GetCppThis(), _arg);
		}
	}
}
