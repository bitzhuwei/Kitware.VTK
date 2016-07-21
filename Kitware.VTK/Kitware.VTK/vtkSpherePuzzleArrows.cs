using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSpherePuzzleArrows : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpherePuzzleArrows";

		public new static readonly string MRClassNameKey;

		static vtkSpherePuzzleArrows()
		{
			vtkSpherePuzzleArrows.MRClassNameKey = "class vtkSpherePuzzleArrows";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpherePuzzleArrows.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpherePuzzleArrows"));
		}

		public vtkSpherePuzzleArrows(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpherePuzzleArrows_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpherePuzzleArrows New()
		{
			vtkSpherePuzzleArrows result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSpherePuzzleArrows() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpherePuzzleArrows_GetPermutation_01(HandleRef pThis);

		public virtual int[] GetPermutation()
		{
			IntPtr intPtr = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_GetPermutation_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpherePuzzleArrows_GetPermutation_02(HandleRef pThis, IntPtr data);

		public virtual void GetPermutation(IntPtr data)
		{
			vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_GetPermutation_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSpherePuzzleArrows_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkSpherePuzzleArrows_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpherePuzzleArrows_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSpherePuzzleArrows NewInstance()
		{
			vtkSpherePuzzleArrows result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkSpherePuzzleArrows_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSpherePuzzleArrows SafeDownCast(vtkObjectBase o)
		{
			vtkSpherePuzzleArrows vtkSpherePuzzleArrows = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpherePuzzleArrows = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpherePuzzleArrows.Register(null);
				}
			}
			return vtkSpherePuzzleArrows;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpherePuzzleArrows_SetPermutation_08(HandleRef pThis, IntPtr data);

		public virtual void SetPermutation(IntPtr data)
		{
			vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_SetPermutation_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpherePuzzleArrows_SetPermutation_09(HandleRef pThis, HandleRef puz);

		public void SetPermutation(vtkSpherePuzzle puz)
		{
			vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_SetPermutation_09(base.GetCppThis(), (puz == null) ? default(HandleRef) : puz.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkSpherePuzzleArrows_SetPermutationComponent_10(HandleRef pThis, int comp, int val);

		public void SetPermutationComponent(int comp, int val)
		{
			vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_SetPermutationComponent_10(base.GetCppThis(), comp, val);
		}
	}
}
