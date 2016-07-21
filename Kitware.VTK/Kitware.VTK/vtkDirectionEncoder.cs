using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkDirectionEncoder : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectionEncoder";

		public new static readonly string MRClassNameKey;

		static vtkDirectionEncoder()
		{
			vtkDirectionEncoder.MRClassNameKey = "class vtkDirectionEncoder";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectionEncoder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectionEncoder"));
		}

		public vtkDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

		public virtual float[] GetDecodedGradient(int value)
		{
			IntPtr intPtr = vtkDirectionEncoder.vtkDirectionEncoder_GetDecodedGradient_01(base.GetCppThis(), value);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

		public virtual IntPtr GetDecodedGradientTable()
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_GetDecodedGradientTable_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

		public virtual int GetEncodedDirection(IntPtr n)
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_GetEncodedDirection_03(base.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

		public virtual int GetNumberOfEncodedDirections()
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_GetNumberOfEncodedDirections_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkDirectionEncoder_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkDirectionEncoder_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectionEncoder_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDirectionEncoder NewInstance()
		{
			vtkDirectionEncoder result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectionEncoder.vtkDirectionEncoder_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectionEncoder_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectionEncoder SafeDownCast(vtkObjectBase o)
		{
			vtkDirectionEncoder vtkDirectionEncoder = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectionEncoder.vtkDirectionEncoder_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectionEncoder = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectionEncoder.Register(null);
				}
			}
			return vtkDirectionEncoder;
		}
	}
}
